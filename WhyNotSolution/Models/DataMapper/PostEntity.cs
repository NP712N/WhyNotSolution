using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Models.DataMapper {
    public class PostEntity : PostDTO {
        public PostEntity() {
            Title = null;
            Content = null;
            Image = null;
            IsAnonymous = true;
            PostByUserId = null;
        }

        public PostEntity(Post postDbModel) {
            Id = postDbModel.Id;
            CreatedDate = postDbModel.CreatedDate;
            LastModify = postDbModel.LastModify;
            Title = postDbModel.Title;
            Content = postDbModel.Content;
            Image = postDbModel.Image;
            IsAnonymous = postDbModel.IsAnonymous;
            PostByUserId = postDbModel.PostByUserId;
        }
    }
}
