using TP_Programación_III.Auth;
using TP_Programación_III.Entities;
using TP_Programación_III.Repository;

namespace TP_Programación_III.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository usuarioRepository)
        {
            _userRepository = usuarioRepository;
        }

        public User? AuthUser(AuthRequestBody authenticationRequest)
        {
            if (String.IsNullOrEmpty(authenticationRequest.Email) || String.IsNullOrEmpty(authenticationRequest.Password))
            {
                return null;
            }
            return _userRepository.ValidateUser(authenticationRequest);
        }
    }
}
