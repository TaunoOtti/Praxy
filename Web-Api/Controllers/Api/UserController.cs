using System;
using System.Collections.Generic;
using System.Linq;
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
    public class UserController : ApiController
    {
        private readonly UserService _service;

        public UserController()
        {
            _service = new UserService();
        }

        public List<UserDTO> getUsers()
        {
            return _service.getAllPersons();
        }

        //public List<User> getUsers()
        //{
        //    return _service.getAllFullPersons();
        //}

        //public UserDTO getUsersById(string id)
        //{
        //    return _service.getUserById(id);
        //}

        [ResponseType(typeof(UserDTO))]
        public IHttpActionResult GetByEmail(string email)
        {
            var user = _service.getUserByEmail(email);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}