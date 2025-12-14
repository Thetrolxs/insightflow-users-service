using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace insightflow_users_service.Src.DTOs
{
    public class EditUserDto
    {
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 150 caracteres.")]
        public required string FullName { get; set; }
    
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 a 150 caracteres.")]
        public required string Username { get; set; }     
    }
}