using ApiSolution.BusinessLayer.Solution_BL;
using ApiSolution.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiSolution.Controllers
{
    public class SolutionController : ApiController
    {
        private SolutionLayer _solutionBuiness;

        public SolutionController()
        {
            _solutionBuiness = new SolutionLayer(new UnitOfWork());
        }

        [System.Web.Http.HttpGet]
        [Route("api/Solution/GetAllPosts")]
        public HttpResponseMessage GetAllPosts()
        {
            var result = _solutionBuiness.GetAllPosts();
            return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
        }

        [System.Web.Http.HttpGet]
        [Route("api/Solution/SearchPost")]
        public HttpResponseMessage SearchPost(string tittle) {

            var result = _solutionBuiness.SearchPost(tittle);
            return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
        }
        [System.Web.Http.HttpPost]
        [Route("api/Solution/SetLike")]
        public HttpResponseMessage SetLike(long commentId)
        {

            var result = _solutionBuiness.SetLike(commentId);
            return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
        }
        [System.Web.Http.HttpPost]
        [Route("api/Solution/SetDisLike")]
        public HttpResponseMessage SetDisLike(long commentId)
        {

            var result = _solutionBuiness.SetDisLike(commentId);
            return Request.CreateResponse(HttpStatusCode.OK, result, Configuration.Formatters.JsonFormatter);
        }
    }
}
