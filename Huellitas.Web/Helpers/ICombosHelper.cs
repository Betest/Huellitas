using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Huellitas.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();
        IEnumerable<SelectListItem> GetComboServiceTypes();
    }
}