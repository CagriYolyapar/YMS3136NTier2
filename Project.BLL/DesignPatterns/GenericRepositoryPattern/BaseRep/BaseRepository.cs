using Project.BLL.DesignPatterns.GenericRepositoryPattern.IntRep;
using Project.BLL.DesignPatterns.SingeltonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepositoryPattern.BaseRep
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext db;
        public BaseRepository()
        {
            db = DBTool.DBInstance;
            
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void Destroy(T item)
        {
            db.Set<T>().Remove(item);
            Save();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetActives()
        {
            return where(x => x.Status != DataStatus.Deleted);

        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetDefault(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetPassive()
        {
            return where(x => x.Status == DataStatus.Deleted);
        }

        public List<T> GetUpdateds()
        {
            return where(x => x.Status== DataStatus.Updated);
        }

        public object select(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public void Updated(T item)
        {
            item.Status = DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T Guncelleneck = Find(item.ID);
            db.Entry(Guncelleneck).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> where(System.Linq.Expressions.Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }
    }
}
