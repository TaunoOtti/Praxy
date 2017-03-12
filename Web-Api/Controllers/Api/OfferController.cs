using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BLL.DTO;
using BLL.Service;
using Domain;

namespace Web_Api.Controllers.Api
{
    [System.Web.Http.Authorize]
    public class OfferController : ApiController
    {
        private readonly OfferService _service;

        public OfferController()
        {
            _service = new OfferService();
        }

        //GET
        public List<OfferFullDTO> getAllOffers()
        {
            return _service.getAllFullOffersDTO();
        }

        //GET
        [ResponseType(typeof(Offer))]
        public IHttpActionResult GetById(int id)
        {
            var offer = _service.GetById(id);

            if (offer == null)
            {
                return NotFound();
            }
            return Ok(offer);
        }

        [ResponseType(typeof(Offer))]
        public IHttpActionResult GetByCatergoryId(int id)
        {
            var offers = _service.getOfferDTOsByCategoryId(id);
            if (offers == null)
            {
                return NotFound();
            }
            return Ok(offers);
        }

        //PUT
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(Offer offer, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_service.Update(offer))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //POST
        [ResponseType(typeof(Offer))]
        public IHttpActionResult Create(Offer offer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var offerr = _service.Create(offer);
            return Ok(offerr);
        }

        //DELETE
        public IHttpActionResult Delete(int id)
        {
            var quer = _service.Delete(id);

            if (quer == false)
            {
                return NotFound();
            }
            return Ok();
        }
            

    }



}
