using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Display(Name = "Raza")]
        public string Race { get; set; }

        [Display(Name = "Fecha nacimiento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://myveterinary.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Fecha nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Born.ToLocalTime();

        public PetType PetType { get; set; }//Relacion 1 a 1 con la entidad tipo mascota

        public Owner Owner { get; set; }//Relacion 1 a 1 con la entidad propietario

        public ICollection<History> Histories { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
