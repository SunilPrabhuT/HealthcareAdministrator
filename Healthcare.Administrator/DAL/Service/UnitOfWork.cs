using Healthcare.Administrator.DAL.Model;
using Healthcare.Administrator.Interface;
using System;

namespace Healthcare.Administrator.Service
{
    /// <summary>
    /// UnitOfWork Class responsible for creating the 
    /// repositories for Db tables and inserting updating 
    /// the records to the DB 
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// CascadeDb context
        /// </summary>
        private readonly SmartChefDbContext _dbContext;

        /// <summary>
        /// Variable for Audit repository
        /// </summary>
        private IBaseRepository<PatientPopulationData> _patientPopulationData;

        /// <summary>
        /// Constructor 
        /// </summary>
        public UnitOfWork()
        {
            _dbContext = new SmartChefDbContext();
        }

        /// <summary>
        /// Variable for Audit repository
        /// </summary>
        private IBaseRepository<SmsLog> _smsLogData;

        /// <summary>
        /// Variable for Audit repository
        /// </summary>
        private IBaseRepository<Master_Patient_Rule> _patientRuleRepo;
        /// <summary>
        /// Gets 
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        private IBaseRepository<Master_Rule> _ruleRepository;

        /// <inheritdoc />
        /// <summary>
        /// This method will 
        /// insert/update
        /// the entries to the Db
        /// </summary>
        public void Save()
        {
            try
            {
                _dbContext.Configuration.AutoDetectChangesEnabled = false;
                _dbContext.SaveChanges(); // Insert the data to the Db 
            }
            finally
            {
                _dbContext.Configuration.AutoDetectChangesEnabled = true;
            }
        }
        private bool _disposed;

        /// <inheritdoc />
        /// <summary>
        ///  Repository for PatientPopulationData
        /// </summary>
        public IBaseRepository<PatientPopulationData> PatientPopulationDataRepository => _patientPopulationData ?? (_patientPopulationData =
                                                                                        new SmartChefRepository<PatientPopulationData>(_dbContext));

        /// <inheritdoc />
        /// <summary>
        ///  Repository for SMSLogData
        /// </summary>
        public IBaseRepository<SmsLog> SmsLogDataRepository => _smsLogData ?? (_smsLogData =new SmartChefRepository<SmsLog>(_dbContext));


        /// <inheritdoc />
        /// <summary>
        ///  Repository for PatientRuleRepository
        /// </summary>
        public IBaseRepository<Master_Patient_Rule> PatientRuleRepository => _patientRuleRepo ?? (_patientRuleRepo = new SmartChefRepository<Master_Patient_Rule>(_dbContext));

        /// <inheritdoc />
        /// <summary>
        ///  Repository for RuleRepository
        /// </summary>
        public IBaseRepository<Master_Rule> RuleRepository => _ruleRepository ?? (_ruleRepository = new SmartChefRepository<Master_Rule>(_dbContext));

        /// <summary>
        /// Disposes the object
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
        /// <summary>
        /// Disposes the Object By
        /// Supressing the Finalize 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}