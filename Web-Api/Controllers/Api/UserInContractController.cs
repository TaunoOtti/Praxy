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
    public class UserInContractController : ApiController
    {
        private readonly UserInContractService _service;

        public UserInContractController()
        {
            _service = new UserInContractService();
        }

        //GET
        public List<UserInContractDTO> getAllOffers()
        {
            return _service.GetUserInContractDtos();
        }

        //GET
        [ResponseType(typeof(UserInContractDTO))]
        public IHttpActionResult GetByUserId(string userId)
        {
            var contract = _service.GetUserInContractsByUserId(userId);

            if (contract == null)
            {
                return NotFound();
            }
            return Ok(contract);
        }

        [ResponseType(typeof(UserInContractDTO))]
        public IHttpActionResult GetByTwoId(string userId, int appliesId)
        {
            var contract = _service.GetUserInContractDTO(userId, appliesId);

            if (contract == null)
            {
                return NotFound();
            }
            return Ok(contract);
        }


        //PUT
        [ResponseType(typeof(void))]
        public IHttpActionResult Update(UsersInContract contract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_service.Update(contract))
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //POST
        [ResponseType(typeof(AppliesToOffer))]
        public IHttpActionResult Create(UsersInContract contract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var offerr = _service.Create(contract);
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