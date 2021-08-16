using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models {
    public class Role: BaseEntity {
        public string RoleName { get; set; }

        //Data configuration DB
        public ICollection<User> Users { get; set; }
    }
}
