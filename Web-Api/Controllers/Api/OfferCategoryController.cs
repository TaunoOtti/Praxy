using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using BLL.Service;
using Domain;

namespace Web_Api.Controllers.Api
{
    [System.Web.Http.Authorize]
    public class OfferCategoryController : ApiController
    {

        private readonly OfferCategoryService _service;

        public OfferCategoryController()
        {
            _service = new OfferCategoryService();
        }

        public List<OfferCategory> GetAllCategoriesd()
        {
            return _service.getAllOfferCategories();
        }

        // GET: OfferCategory getAllOfferCategories
        //[ResponseType(typeof(Offer))]
        //public IHttpActionResult GetAllOfferCategorys()
        //{
        //    var offers = _service.getAllOfferCategories();
        //    if (offers == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(offers);
        //}
        
    }
}