using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Repository {
    public interface IRepository<T, Y> {
        ICollection<T> GetAll();
        T GetById(int id);
        int Create(Y entity);
        bool Delete(int Id);
    }
}
