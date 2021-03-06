﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class EFRepository<T> : IEFRepository<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public EFRepository(IDbContext dbContext)
        {

            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext));

            DbContext = dbContext as DbContext;
            //get the dbset from context
            if (DbContext != null) DbSet = DbContext.Set<T>();

        }

        public List<T> All => DbSet.ToList();


        public List<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return includeProperties.
                Aggregate<Expression<Func<T, object>>, IQueryable<T>>(DbSet,
                    (current, includeProperty) => current.Include(includeProperty)).ToList();
        }


        public T GetById(params object[] id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        public void Delete(params object[] id)
        {
            var entity = GetById(id);
            if (entity == null) return;
            Delete(entity);
        }


        public EntityKey GetPrimaryKeyInfo(T entity)
        {
            var properties = typeof(DbSet).GetProperties();
            foreach (
                var objectContext in
                    properties.Select(propertyInfo => ((IObjectContextAdapter)DbContext).ObjectContext))
            {
                ObjectStateEntry objectStateEntry;
                if (null != entity && objectContext.ObjectStateManager
                    .TryGetObjectStateEntry(entity, out objectStateEntry))
                {
                    return objectStateEntry.EntityKey;
                }
            }
            return null;
        }

        public string[] GetKeyNames(T entity)
        {
            var objectSet = ((IObjectContextAdapter)DbContext).ObjectContext.CreateObjectSet<T>();
            var keyNames = objectSet.EntitySet.ElementType.KeyMembers.Select(k => k.Name).ToArray();
            return keyNames;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
           
        }
    }
}