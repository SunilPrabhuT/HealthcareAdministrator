using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.Administrator.Interface
{
    /// <summary>
    /// IUnitOfWork interface
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Saves the record to Db
        /// </summary>
        void Save();
    }
}
