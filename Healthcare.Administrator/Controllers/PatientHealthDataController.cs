using Healthcare.Administrator.BAL.Interface;
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
        /// The IPatientData variable
        /// </summary>
        private readonly IPatientData _iPatientData;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="IPatientData"></param>
        public PatientHealthDataController(IPatientData IPatientData)
        {
            _iPatientData = IPatientData;
        }
        /// <summary>
        /// Gets the Patient Data
        /// </summary>
        /// <returns></returns>
        [HttpPost]
       // [Authorize]
        [Route("GetPatientData")]
        public IHttpActionResult GetPatientData(string userName)
        {
            return Ok(_iPatientData.GetPatientData(userName));
        }
    }
}
