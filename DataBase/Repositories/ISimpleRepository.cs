using DataBase.DataBaseBuses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public interface ISimpleRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int page, int size);
        T Get(int id);
        void Save(T obj);
        void Create(T obj);
        void Delete(T obj);
    }

    public interface IChildRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int UserId, int RoleId);
        T Get(int id);
        void Save(T obj);
        void Create(T obj);
        void Delete(T obj);
    }
}
