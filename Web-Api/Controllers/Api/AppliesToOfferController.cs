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
    public class AppliesToOfferController : ApiController
    {
        private readonly AppliesToOfferService _service;

        public AppliesToOfferController()
        {
            _service = new AppliesToOfferService();
        }

        //GET
        public List<AppliesToOfferDTO> getAllOffers()
        {
            return _service.getAllAppliesToOfferDTO();
        }

        //GET
        [ResponseType(typeof(AppliesToOfferDTO))]
        public IHttpActionResult GetById(int id, string userId)
        {
            var aplOfr = _service.getApplieToOfferWithTwoIds(userId, id);

            if (aplOfr == null)
            {
                return NotFound();
            }
            return Ok(aplOfr);
        }

        [ResponseType(typeof(List<AppliesToOfferDTO>))]
        public IHttpActionResult GetByUserId(string userId)
        {
            var aplOfr = _service.getAllUserApplies(userId);

            if (aplOfr == null)
            {
                return NotFound();
            }
            return Ok(aplOfr);
        }


        //PUT
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(AppliesToOffer offer, int id)
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
        [ResponseType(typeof(AppliesToOffer))]
        public IHttpActionResult Create(AppliesToOffer offer)
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