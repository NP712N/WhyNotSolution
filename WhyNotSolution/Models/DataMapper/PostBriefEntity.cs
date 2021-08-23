using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Models.DataMapper {
    public class PostBriefEntity: BaseEntity {
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public bool IsAnonymous { get; set; }
        public int? PostByUserId { get; set; }

        public PostBriefEntity() {}

        public PostBriefEntity(Post postDbModel) {
            Id = postDbModel.Id;
            CreatedDate = postDbModel.CreatedDate;
            LastModify = postDbModel.LastModify;
            Title = postDbModel.Title;
            Image = postDbModel.Image;
            IsAnonymous = postDbModel.IsAnonymous;
            PostByUserId = postDbModel.PostByUserId;
        }

    }
}
