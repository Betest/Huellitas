﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de servicio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede ser mayor de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public ICollection<History> Histories { get; set; }//relacion 1 a * con la entidad Historia
    }
}
