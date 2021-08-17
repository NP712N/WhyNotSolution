using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models;
using WhyNotSolution.Models.DataMapper;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Repository {
    public interface IPostRepository : IRepository<PostEntity, PostCreateRequest> {
        bool UpdateTitle(int Id, string title);
    }
}
