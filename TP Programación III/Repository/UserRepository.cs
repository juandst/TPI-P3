using TP_Programación_III.Auth;
using TP_Programación_III.Data.Context;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }

        public User? ValidateUser(AuthRequestBody request)
        {

            var user = _context.Users.FirstOrDefault(a => a.Email == request.Email && a.Password == request.Password);
            return user;
        }
    }
}
