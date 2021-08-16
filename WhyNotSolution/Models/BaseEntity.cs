using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyNotSolution.Models {
    public abstract class BaseEntity {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModify { get; set; }
    }
}
