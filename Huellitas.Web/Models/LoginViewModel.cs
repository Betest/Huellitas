using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress]
        
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MinLength(6, ErrorMessage = "El campo {0} no puede tener menos de {1} caracteres.")]
        
        public string Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}
