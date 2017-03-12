using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;



namespace Client.Services
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
