using Healthcare.Administrator.DAL.Model;
using Healthcare.Administrator.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Healthcare.Administrator.Service
{
    /// <summary>
    /// Base Repository
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class SmartChefRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The CascadeDbContext variable
        /// </summary>
        internal SmartChefDbContext context;
        /// <summary>
        /// The dbSet variable
        /// </summary>
        internal DbSet<TEntity> dbSet;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public SmartChefRepository(SmartChefDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }
        /// <summary>
        /// Generic function to get all the
        /// matching records as per filter criteria
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }
        /// <summary>
        /// Generic function to get the
        /// matching records By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }
        /// <summary>
        /// Generic function to get insert the
        /// record to the db
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }
        /// <summary>
        /// Generic function to delete the
        /// record from db by matching the Id
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }
        /// <summary>
        /// Generic function to delete the
        /// record from db by matching the entity
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }
        /// <summary>
        /// Generic function to update the
        /// record from db by matching the entity
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(TEntity entityToUpdate)
        {
            //var entry= dbSet.Attach(entityToUpdate);
            // Backup updated values
            //context.Configuration.AutoDetectChangesEnabled = false;
            // context.Configuration.AutoDetectChangesEnabled = false;
            //context.Configuration.ValidateOnSaveEnabled = false;
            //dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        /// <summary>
        /// The disposes variable
        /// </summary>
        private bool disposed = false;
        /// <summary>
        /// Disposes the entity
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        /// <summary>
        /// The disposes variable
        /// by suppressing the finalize
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}