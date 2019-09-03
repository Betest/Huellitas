using Huellitas.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huellitas.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            /*var list = new List<SelectListItem>();
            foreach(var petType in _dataContext.PetTypes)
            {
                list.Add(new SelectListItem
                {
                    Text = petType.Name,
                    Value = $"{petType.Id}"
                });
                
            }*/
            var list = _dataContext.PetTypes.Select(pt => new SelectListItem//exprecion linq mas rapido que la instruccion anterior
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de mascota.]",
                Value = "0"
            });


            return list;
        }

        public IEnumerable<SelectListItem> GetComboServiceTypes()
        {
            var list = _dataContext.ServiceTypes.Select(pt => new SelectListItem//exprecion linq mas rapido que la instruccion anterior
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de servicio.]",
                Value = "0"
            });


            return list;
        }
    }
}
