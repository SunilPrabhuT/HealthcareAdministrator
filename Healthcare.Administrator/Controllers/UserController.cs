using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Healthcare.Administrator.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        /// <summary>
        /// Gets the Username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserName")]
        public IHttpActionResult GetUsername(string userName)
        {
            return Ok(userName);
        }
    }
}
