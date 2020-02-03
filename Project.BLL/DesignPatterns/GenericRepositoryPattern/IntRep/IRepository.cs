using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepositoryPattern.IntRep
{
 public   interface IRepository<T> where T :BaseEntity
    {
        List<T> GetAll();//Tüm Database'i Getircek.
        T Find(int id);//ID e göre bulma
        List<T> GetActives();
        List<T> GetPassive();
        List<T> GetUpdateds();
        //Modifikasyon
        void Add(T item);
        void Updated(T item);
        void Destroy(T item);
        void Delete(T item);

        List<T> where(Expression<Func<T, bool>> exp);
        T GetDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);

        object select(Expression<Func<T, bool>> exp);

    }
}
