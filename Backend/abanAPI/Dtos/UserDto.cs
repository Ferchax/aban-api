using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace abanAPI.Dtos
{
    public class UserDto
    {
        [Required(ErrorMessage = "Debe ingresar al menos un nombre.")]
        public string Nombres { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Debe ingresar al menos un apellido.")]
        public string Apellidos { get; set; } = string.Empty;

        public DateTime? FechaDeNacimiento { get; set; }

        public string? Cuit { get; set; }
        public string? Domicilio { get; set; }
        public string? Celular { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un mail.")]
        public string Email { get; set; } = string.Empty;
    }
}