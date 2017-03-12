using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using BLL.DTO;
using BLL.Service;
using Domain;

namespace Web_Api.Controllers.Api
{

    public class CvController : ApiController
    {
        private readonly CvService _service;
        public CvController()
        {
            _service = new CvService();
        }

        public List<CvSmallDTO> GetSmallCvs()
        {
            return _service.getAllSmallCvs();
        }

        [ResponseType(typeof(CvFullDTO))]
        public IHttpActionResult GetCv(int id)
        {
            var cv = _service.GetCvById(id);

            if(cv == null) return NotFound();

            return Ok(cv);
        }

        //public IHttpActionResult PutModelSerie(int id, Cv cv)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _service.

        //    return StatusCode(HttpStatusCode.NoContent);
        //}
    }
}