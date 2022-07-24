using System.ComponentModel.DataAnnotations;

namespace TP_Programación_III.Models.Create
{
    public class UserCreateDTO
    {
        [Required(ErrorMessage = "Ingrese un nombre")]
        [MinLength(2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ingrese un email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Ingrese una contraseña")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener como mínimo 8 caracteres")]
        public string Password { get; set; }
        public bool isAdmin = false;
    }
}
