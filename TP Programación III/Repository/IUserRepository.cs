using TP_Programación_III.Auth;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
{
    public interface IUserRepository
    {
        User? ValidateUser(AuthRequestBody authenticationRequest);

        public void AddUser(User user);
        bool SaveChangesBool();
    }
}
