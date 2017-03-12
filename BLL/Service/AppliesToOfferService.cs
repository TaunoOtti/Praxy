using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Factories;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace BLL.Service
{
    public class AppliesToOfferService
    {
        private IAppliesToOfferRepository _repo;
        private AppliesToOfferFactory _factory;

        public AppliesToOfferService()
        {
            this._repo = new AppliesToOfferRepository(new ApplicationDbContext());
            this._factory = new AppliesToOfferFactory();
        }

        public List<AppliesToOfferDTO> getAllAppliesToOfferDTO()
        {
            return this._repo.All.Select(x => _factory.CreateBasicAppliesToOfferDTO(x)).ToList();
        }

        public List<AppliesToOfferDTO> getAllUserApplies(string userId)
        {
            var res = this._repo.All.Where(x => x.UserId == userId).ToList();
            List<AppliesToOfferDTO> list = res.Select(usr => _factory.CreateBasicAppliesToOfferDTO(usr)).ToList();
            return list;
        }

        public AppliesToOffer getApplieToOfferWithTwoIds(string userId, int OfferId)
        {
            return _repo.getAppliesToOfferByTwoId(userId, OfferId);
        }

        public bool Update(AppliesToOffer applies)
        {
            _repo.Update(applies);
            _repo.SaveChanges();
            return true;
        }

        public AppliesToOffer Create(AppliesToOffer applies)
        {
            _repo.Add(applies);
            _repo.SaveChanges();

            return applies;
        }

        public bool Delete(int id)
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
