using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace insightflow_users_service.Src.DTOs
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 150 caracteres.")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El Email no tiene un formato válido.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 150 caracteres.")]
        public required string Username { get; set; } 
        
        [Required(ErrorMessage = "La Fecha de Nacimiento es obligatoria.")]
        [DataType(DataType.Date)] 
        public DateTime birthday { get; set; }

        [Required(ErrorMessage = "La dirección es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 150 caracteres.")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [RegularExpression(@"^(\+56\s?)?(9)(\s*\d){8}$", ErrorMessage = "El número de teléfono no tiene un formato chileno válido. Debe ser móvil (ej. 9XXXXXXXX o +56 9XXXXXXXX).")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "La Contraseña es obligatoria.")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]+$", ErrorMessage = "La Contraseña debe ser alfanumérica.")]
        [MinLength(8, ErrorMessage = "La Contraseña debe tener al menos 8 caracteres.")]
        [MaxLength(20, ErrorMessage = "La Contraseña debe tener a lo más 20 caracteres.")]
        public required string Password { get; set; }
    }
}