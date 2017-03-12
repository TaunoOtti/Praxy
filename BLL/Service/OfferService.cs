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
    public class OfferService
    {
        private IOfferRepository _repo;
        private OfferFactory _factory;

        public OfferService()
        {
            this._repo = new OfferRepository(new ApplicationDbContext());
            this._factory = new OfferFactory();
        }

        public List<OfferSmallDTO> getAllSmallOffersDTO()
        {
            return this._repo.All.Select(x => _factory.createSmallOfferDTO(x)).ToList();
        }

        public List<OfferFullDTO> getAllFullOffersDTO()
        {
            return this._repo.All.Select(x => _factory.createFullOfferDTO(x)).ToList();
        }

        public List<OfferSmallDTO> getOfferDTOsByCategoryId(int id)
        {
            var list = this._repo.All.Where(x => x.OfferCategoryId == id).ToList();
            return list.Select(offer => _factory.createSmallOfferDTO(offer)).ToList();
        }

        public Offer GetById(int id)
        {
            return this._repo.GetById(id);
        }

        public bool Update(Offer offer)
        {
            _repo.Update(offer);
            _repo.SaveChanges();
            return true;
        }

        public Offer Create(Offer offer)
        {
            _repo.Add(offer);
            _repo.SaveChanges();
           
            return offer;
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
