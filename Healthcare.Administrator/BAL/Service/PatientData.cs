using Healthcare.Administrator.BAL.Interface;
using Healthcare.Administrator.Interface;
using Healthcare.Administrator.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Healthcare.Administrator.BAL.Service
{
    /// <summary>
    /// PatientData
    /// </summary>
    public class PatientData :IPatientData
    {
        /// <summary>
        /// The IUnitOfWork variable
        /// </summary>
        private readonly IUnitOfWork _iunitOfWork;
        /// <summary>
        /// Constructor
        /// </summary>
        public PatientData(IUnitOfWork iunitOfWork)
        {
            _iunitOfWork = iunitOfWork;
        }
        /// <summary>
        /// Gets the Patient Data
        /// </summary>
        /// <returns></returns>
        public List<PatientDataResponseDto> GetPatientData()
        {
            List<PatientDataResponseDto> patientDataResponseDto = new List<PatientDataResponseDto>();
            return _iunitOfWork.PatientPopulationDataRepository.Get().ToList().Select(ptData => new PatientDataResponseDto
            {
                PatientName = ptData?.Patient_Name,
                MemberDependent = ptData?.Member___Dependent,
                Gender = ptData?.Gender,
                DOB = Convert.ToString(ptData?.DOB),
                Country = ptData?.County,
                City = ptData.City,
                State = ptData?.State,
                ZipCode = Convert.ToString(ptData?.ZipCode),
                PCP = ptData.PCP,
                BMI = Convert.ToString(ptData.BMI),
                DiabetesLevel = Convert.ToString(ptData?.Diabetes_Level),
                Date = Convert.ToString(ptData?.Date),
                Date1 = Convert.ToString(ptData?.Date1),
                Date2 = Convert.ToString(ptData?.Date2),
                Date3 = Convert.ToString(ptData?.Date3),
                Date4 = Convert.ToString(ptData?.Date4),
                InitialFinding1 = ptData?.Initial__First__Findings,
                PreviousFinding1 = ptData?.Previous_Findings_1,
                PreviousFinding2 = ptData?.Previous_Findings_2,
                PreviousFinding3 = ptData?.Previous_Findings_3,
                PreviousFinding4 = ptData?.Previous_Findings_4,
                CurrentFindings = ptData?.Current_Findings,
                Systolic = Convert.ToString(ptData?.systolic),
                Diastolic = Convert.ToString(ptData?.Diastolic),
                Smoking = Convert.ToString(ptData?.Smoking),
                Pyscian = Convert.ToString(ptData?.Phy_Name),
                Nurse = Convert.ToString(ptData?.Nurse_Name)
            }).ToList();
        }
    }
}