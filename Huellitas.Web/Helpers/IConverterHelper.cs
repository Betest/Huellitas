using System.Threading.Tasks;
using Huellitas.Web.Data.Entities;
using Huellitas.Web.Models;

namespace Huellitas.Web.Helpers
{
    public interface IConverterHelper
    {
        
        //Task<Pet> ToPetAsync(PetViewModel model, string path);

        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);
        PetViewModel ToPetViewModel(Pet pet);

        Task<History> ToHistoryAsync(HistoryViewModel model, bool isNew);

        HistoryViewModel ToHistoryViewModel(History history);

    }
}