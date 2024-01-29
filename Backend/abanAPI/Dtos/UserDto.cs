using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abanAPI.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;        
        public string Apellidos { get; set; } = string.Empty;
        public DateTime? FechaDeNacimiento { get; set; }
        public string? Cuit { get; set; }
        public string? Domicilio { get; set; }
        public string? Celular { get; set; }        
        public string Email { get; set; } = string.Empty;
    }
}