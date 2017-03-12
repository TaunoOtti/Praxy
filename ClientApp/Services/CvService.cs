using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Services
{
    public class CvService : BaseService
    {

        public CvService() : base(ServicUrls.CvServiceUrl)
        {
            
        }

        public async Task<ObservableCollection<Cv>> GetAll()
        {
            return await base.Get<ObservableCollection<Cv>>("");
        }
    }
}
