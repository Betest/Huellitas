using Huellitas.Web.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Models
{
    public class PetViewModel : Pet
    {
        public int OwnerId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo mascota")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de mascota.")]
        public int PetTypeId { get; set; }

        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }

        public IEnumerable<SelectListItem> PetTypes { get; set; }
    }
}
