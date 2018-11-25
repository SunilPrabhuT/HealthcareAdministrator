using Healthcare.Administrator.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.Administrator.BAL.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public interface IPatientData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        List<PatientDataResponseDto> GetPatientData(string userName);
    }
}
