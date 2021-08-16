using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Models.DataMapper {
    public class RoleEntity : RoleDTO {
        public RoleEntity() {
            RoleName = null;
        }

        public RoleEntity(Role roleDbModel) {
            Id = roleDbModel.Id;
            CreatedDate = roleDbModel.CreatedDate;
            LastModify = roleDbModel.LastModify;
            RoleName = roleDbModel.RoleName;
        }
    }
}
