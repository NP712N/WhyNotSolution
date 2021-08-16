using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Repository {
    public interface IRepository<T> {
        ICollection<T> GetAll();
        T GetById(int id);
        int Create(T entity);
        bool Update(T entity);
        bool Delete(int Id);
    }
}
