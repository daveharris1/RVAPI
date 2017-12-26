using RVApiHandler.Models;
using RVApiHandler.RVFacadeHandler;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RVApi.Controllers
{
    public class RVVilessController : ApiController
    {
        private IRVFacade _rvFacade;

        public RVVilessController(IRVFacade rvFacade)
        {
            _rvFacade = rvFacade;
        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        public IHttpActionResult GetRVContent()
        {
            try
            {
                RVHttpResponseModel rvHttpResponseModel = _rvFacade.GetRVContent();
                return Ok(rvHttpResponseModel);
            }
            catch (Exception ex)
            {
                return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.ToString()));
            }
        }
    }
}
