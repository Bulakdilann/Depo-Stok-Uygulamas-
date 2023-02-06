using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List(); //listele yaptırıyoruz
        void Insert(T p);
        void Update(T p, int id);
        void Delete(int İd);
        List<T> List(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);

        T Find(int id);
    }
}
