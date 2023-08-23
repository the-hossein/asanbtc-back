using System;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Contract;
using System.Linq.Expressions;
using DataLayer.Entities;

namespace RepositoryLayer.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AsanBtcDbContext RepositoryContext { get; set; }
       
        public RepositoryBase(AsanBtcDbContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
            
        }
        public async Task<IQueryable<T>> FindAll()
        {
            try
            {
                var TheContexts = RepositoryContext.Set<T>().Take(100).AsQueryable();
                return TheContexts;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public IQueryable<T> FindListByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return this.RepositoryContext.Set<T>().Where(expression).Take(300).AsQueryable();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public T FindByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return this.RepositoryContext.Set<T>().FirstOrDefault(expression);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public T Create(T entity)
        {

            try
            {
                var en = this.RepositoryContext.Set<T>().Add(entity).Entity;
                this.RepositoryContext.SaveChanges();
                return en;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }

        public bool Update(T entity)
        {
            try
            {
                //this.RepositoryContext.Entry<T>(entity).State = EntityState.Detached;
                this.RepositoryContext.Entry<T>(entity).State = EntityState.Modified;
                //this.RepositoryContext.Set<T>().Update(entity).Property("IntId").IsModified = false;
                this.RepositoryContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                this.RepositoryContext.Set<T>().Remove(entity);
                this.RepositoryContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
        }

        public int GetALlFilteredByCount(Expression<Func<T, bool>> expression)
        {
            try
            {
                var pi = typeof(T).GetProperty("Id", System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                return this.RepositoryContext.Set<T>().Where(expression).Select(a => pi.GetValue(a, null)).Count();
            }
            catch (Exception)
            {
                Console.WriteLine("Error in GetALlFilteredByCount");
                return 0;
            }
        }


        public int GetAllCount()
        {
            try
            {
                var pi = typeof(T).GetProperty("Id", System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                return this.RepositoryContext.Set<T>().Count();
            }
            catch (Exception)
            {
                Console.WriteLine("Error in GetALlFilteredByCount");
                return 0;
            }
        }
    }
}

