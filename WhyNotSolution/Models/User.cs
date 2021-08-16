using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models {
    public class User {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModify { get; set; }

        //Data configuration DB
        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
