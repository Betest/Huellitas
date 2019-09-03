using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Pet> Pets { get; set; }//relacion 1 a * con la entidad mascota

        public ICollection<Agenda> Agendas { get; set; }//relacion 1 a * con la entidad agenda
    }
}
