﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.Administrator.Infrastructure
{
    /// <inheritdoc />
    /// <summary>
    /// Application Db Context class
    /// </summary>
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <inheritdoc />
        /// <summary>
        /// The context class
        /// </summary>
        public ApplicationDbContext()
            : base("SmartChefDbContext", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        /// <summary>
        /// Creates the context 
        /// </summary>
        /// <returns></returns>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


    }
}
