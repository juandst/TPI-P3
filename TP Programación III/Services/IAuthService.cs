using TP_Programación_III.Auth;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Services
{
    public interface IAuthService
    {
        public User? AuthUser(AuthRequestBody authenticationRequest);
    }
}
