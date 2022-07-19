using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TP_Programación_III.Entities;
using TP_Programación_III.Services;

namespace TP_Programación_III.Auth
{
    [Route("api/login")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAuthService _authService;

        public AuthenticationController(IConfiguration config, IAuthService authService)
        {
            _config = config;
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(AuthRequestBody authenticationRequestBody)
        {
            //Paso 1: Validamos las credenciales
            var usuario = Validate(authenticationRequestBody); //Lo primero que hacemos es llamar a una función que valide los parámetros que enviamos.

            if (usuario is null) //Si el la función de arriba no devuelve nada es porque los datos son incorrectos, por lo que devolvemos un Unauthorized (un status code 401).
                return Unauthorized();

            //Paso 2: Crear el token
            var claveDeSeguridad = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"])); //Traemos la SecretKey del Json. agregar antes: using Microsoft.IdentityModel.Tokens;

            var credenciales = new SigningCredentials(claveDeSeguridad, SecurityAlgorithms.HmacSha256);

            //Los claims son datos en clave->valor que nos permite guardar data del usuario.
            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", usuario.UserID.ToString())); //"sub" es una key estándar que significa unique user identifier, es decir, si mandamos el id del usuario por convención lo hacemos con la key "sub".
            claimsForToken.Add(new Claim("given_name", usuario.Name)); //Lo mismo para given_name y family_name, son las convenciones para nombre y apellido. Ustedes pueden usar lo que quieran, pero si alguien que no conoce la app
            claimsForToken.Add(new Claim("role", usuario.IsAdmin ? "admin" : "user"));

            var jwtSecurityToken = new JwtSecurityToken( //agregar using System.IdentityModel.Tokens.Jwt; Acá es donde se crea el token con toda la data que le pasamos antes.
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credenciales);

            var tokenToReturn = new JwtSecurityTokenHandler() //Pasamos el token a string
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }

        private User Validate(AuthRequestBody userParams)
        {
            return _authService.AuthUser(userParams);
        }
    }
}
