using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;
using TP_Programación_III.Models.Create;
using TP_Programación_III.Repository;

namespace TP_Programación_III.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<UserDTO> AddUser(UserCreateDTO userToCreate)
        {
            User newUser = _mapper.Map<User>(userToCreate);
            _repository.AddUser(newUser);
            _repository.SaveChangesBool();
            return CreatedAtRoute("",
                new
                {
                    userId = newUser.UserID
                },
                _mapper.Map<UserDTO>(newUser));
        }
    }
}
