using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models.EF {
    public class UserDTO {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModify { get; set; }
        public int? RoleId { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
