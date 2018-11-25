using Healthcare.Administrator.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.Administrator.BAL.Interface
{
    public interface IPatientData
    {
        List<PatientDataResponseDto> GetPatientData();
    }
}
