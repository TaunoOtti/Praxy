using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Factories;
using DAL;
using DAL.Repositories;
using Domain;

namespace BLL.Service
{
    public class CvService
    {
        private EFRepository<Cv> _repo;
        private CvFactory _factory;

        public CvService()
        {
            this._repo = new CVRepository(new ApplicationDbContext());
            this._factory = new CvFactory();
        }

        public List<CvSmallDTO> getAllSmallCvs()
        {
            return this._repo.All.Select(x => _factory.createCvSmallDTO(x)).ToList();
        }

        public CvFullDTO GetCvById(int id)
        {
            var cv = _repo.All.FirstOrDefault(x => x.CvId == id);
            if (cv == null) return null;

            return _factory.createCvFullDTO(cv);
        }

        public void UpdateCv(Cv cv)
        {
            _repo.Update(cv);          
            _repo.SaveChanges();       

        }

        public CvFullDTO CreateCv(Cv cv)
        {
            _repo.Add(cv);
            _repo.SaveChanges();

            return _factory.createCvFullDTO(cv);
        }

        public bool DeleteCv(int id)
        {
            var quer = _repo.GetById(id);

            if (quer == null)
            {
                return false;
            }
            _repo.Delete(id);
            _repo.SaveChanges();

            return true;

        }

    }
}
