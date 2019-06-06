using FinalProj.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj.DAO
{
    public interface IBasicDB<T> where T : IPoco
    {
        IList<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Remove(T t);
        void Update(T t);
    }
}
