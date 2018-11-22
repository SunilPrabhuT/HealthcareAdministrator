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
    [RoutePrefix("api/PatientHealthData")]
    public class PatientHealthDataController : ApiController
    {
        /// <summary>
        /// Gets the Patient Data
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("GetPatientData")]
        public IHttpActionResult GetPatientData()
        {
            return Ok("hi");
        }
    }
}
