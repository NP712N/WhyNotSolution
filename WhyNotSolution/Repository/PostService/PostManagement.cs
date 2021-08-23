using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WhyNotSolution.Models;
using WhyNotSolution.Models.Database;
using WhyNotSolution.Models.DataMapper;
using WhyNotSolution.Models.EF;

namespace WhyNotSolution.Repository.PostService {
    public class PostManagement : IPostRepository {

        private readonly SolutionDbContext SolutionDbContext;
        public PostManagement(SolutionDbContext solutionDbContext) {
            SolutionDbContext = solutionDbContext;
        }

        public int Create(PostCreateRequest entity) {
            var newPost = new Post() {
                Title = entity.Title,
                Content = entity.Content,
                Image = entity.Image,
                IsAnonymous = entity.PostByUserId == null || entity.PostByUserId == 0,
                PostByUserId = entity.PostByUserId < 1 ? null : entity.PostByUserId
            };
            SolutionDbContext.Posts.Add(newPost);

            if (Save())
                return newPost.Id;

            return 0;
        }

        public bool Delete(int Id) {
            var post = SolutionDbContext.Posts.FirstOrDefault(p => p.Id == Id);
            if (post == null) return false;

            SolutionDbContext.Posts.Remove(post);
            return Save();
        }

        public ICollection<PostEntity> GetAll() {
            var posts = SolutionDbContext.Posts.OrderBy(r => r.CreatedDate).ToList();
            var result = posts.Select(post => new PostEntity(post)).ToList();

            return result;
        }

        public ICollection<PostBriefEntity> GetBriefPosts() {
            var posts = SolutionDbContext.Posts.OrderBy(r => r.CreatedDate).ToList();
            var result = posts.Select(post => new PostBriefEntity(post)).ToList();

            return result;
        }

        public PostEntity GetById(int id) {
            var post = SolutionDbContext.Posts.FirstOrDefault(p => p.Id == id);
            return new PostEntity(SolutionDbContext.Posts.FirstOrDefault(p => p.Id == id));
        }

        public bool UpdateTitle(int Id, string title) {
            var post = SolutionDbContext.Posts.FirstOrDefault(p => p.Id == Id);
            if (post == null) return false;

            post.Title = title;

            return Save();
        }

        public bool Update(PostEntity entity) {
            var post = SolutionDbContext.Posts.FirstOrDefault(p => p.Id == entity.Id);
            if (post == null) return false;

            foreach (PropertyInfo prop in entity.GetType().GetProperties()) {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                if (type == typeof(DateTime)) {
                }
            }

            post.Content = entity.Content;
            post.Title = entity.Title;
            post.Image = entity.Image;
            if (entity.PostByUserId != null) {
                var user = SolutionDbContext.Users.FirstOrDefault(u => u.Id == entity.PostByUserId);

                if (user != null) {
                    post.User = user;
                    post.IsAnonymous = false;
                }
            }

            return Save();
        }

        private bool Save() {
            return SolutionDbContext.SaveChanges() < 0 ? false : true;
        }

        public PostBriefEntity GetBriefPost(int Id) {
            var post = SolutionDbContext.Posts.FirstOrDefault(p => p.Id == Id);

            return post != null
                ? new PostBriefEntity() {
                    Id = post.Id,
                    Title = post.Title,
                    CreatedDate = post.CreatedDate,
                    Image = post.Image,
                    IsAnonymous = post.IsAnonymous,
                    PostByUserId = post.User?.Id,
                    LastModify = post.LastModify
                }
                : null;
        }

        public string GetContent(int Id) {
            var post = SolutionDbContext.Posts.FirstOrDefault(s => s.Id == Id);

            return post !=null ? post.Content : null;
        }
    }
}
