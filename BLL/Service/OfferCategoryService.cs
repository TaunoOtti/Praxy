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
    public class OfferCategoryService
    {
        private readonly EFRepository<OfferCategory> _repo;
        private readonly OfferCategoryFactory _factory;

        public OfferCategoryService()
        {
            this._repo = new OfferCategoryRepository(new ApplicationDbContext());
            this._factory = new OfferCategoryFactory();
        }

        public List<OfferCategory> getAllOfferCategories()
        {
            return this._repo.All;
        } 
    }
}
