using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models.EF {
    public class PostDTO: BaseEntity {
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public bool IsAnonymous { get; set; }
        public int? PostByUserId { get; set; }
    }

    public class PostCreateRequest {
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] Image { get; set; }
        public int? PostByUserId { get; set; }
    }

    public class PostUpdateTitleRequest {
        public string Title { get; set; }
    }
}
