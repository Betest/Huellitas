using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Display(Name = "Comentarios")]
        public string Remarks { get; set; }

        [Display(Name = "Esta disponible?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();

        public Owner Owner { get; set; }//relacion 1 a 1 con la entidad propietario

        public Pet Pet { get; set; }//relacion 1 a 1 con la entidad mascota
    }
}
