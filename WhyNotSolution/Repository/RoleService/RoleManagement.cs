using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models;
using WhyNotSolution.Models.Database;
using WhyNotSolution.Models.DataMapper;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Repository.RoleService {
    public class RoleManagement : IRoleRepository {

        private readonly SolutionDbContext SolutionDbContext;

        public RoleManagement(SolutionDbContext solutionDbContext) {
            SolutionDbContext = solutionDbContext;
        }

        public int Create(RoleDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<RoleEntity> GetAll()
        {
            var roles = SolutionDbContext.Roles.OrderBy(r => r.RoleName).ToList();
            var result = RolesConverter(roles);

            return result;
        }

        public RoleEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(RoleEntity entity)
        {
            throw new NotImplementedException();
        }

        private ICollection<RoleEntity> RolesConverter(List<Role> roles) {
            List<RoleEntity> result = new List<RoleEntity>();
            foreach (var role in roles) {
                result.Add(new RoleEntity(role));
            }

            return result;
        }
    }
}
