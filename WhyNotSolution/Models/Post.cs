using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models {
    public class Post: BaseEntity {
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public bool IsAnonymous { get; set; }

        //Data configuration DB
        public int? PostByUserId { get; set; }
        public User User { get; set; }
    }
}
