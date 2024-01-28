using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace abanAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required]
        public string Nombres { get; set; } = string.Empty;
        
        [Required]
        public string Apellidos { get; set; } = string.Empty;

        [Column("Fecha de Nacimiento")]
        public DateTime? FechaDeNacimiento { get; set; }

        [Column("CUIT")]
        public string? Cuit { get; set; }
        public string? Domicilio { get; set; }
        public string? Celular { get; set; }
        
        [Required]
        public string Email { get; set; } = string.Empty;
    }
}