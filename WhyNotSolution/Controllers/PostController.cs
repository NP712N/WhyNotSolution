using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhyNotSolution.Models.DataMapper;
using WhyNotSolution.Models.EF;
using WhyNotSolution.Repository;

namespace WhyNotSolution.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase {
        private readonly IPostRepository PostRepository;
        public PostController(IPostRepository postRepository) {
            PostRepository = postRepository;
        }

        [HttpGet]
        public IActionResult GetPosts() {
            var list = PostRepository.GetAll();
            return Ok(list);
        }

        [HttpGet("getBriefPosts")]
        public IActionResult GetBriefPosts() {
            var list = PostRepository.GetBriefPosts();
            return Ok(list);
        }

        [HttpGet("{id}", Name = "GetPost")]
        public IActionResult GetPost(int id) {
            var post = PostRepository.GetById(id);
            if (post == null) {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpGet("{id}/getBriefPost", Name = "GetBriefPost")]
        public IActionResult GetBriefPost(int id) {
            var post = PostRepository.GetBriefPost(id);
            if (post == null) {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpGet("{id}/getContent", Name = "GetContent")]
        public IActionResult GetContent(int id) {
            var content = PostRepository.GetContent(id);
            if (content == null) {
                return NotFound();
            }

            return Ok(new JsonResult(content));
        }

        [HttpPost]
        public IActionResult CreatePost([FromBody] PostCreateRequest request) {
            if (request == null) {
                return BadRequest(ModelState);
            }

            var postId = PostRepository.Create(request);
            if (postId == 0) {
                ModelState.AddModelError("", $"Something went wrong when adding {request.Title}");
                return StatusCode(500, ModelState);
            }

            return GetPost(postId);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id) {
            if (!PostRepository.Delete(id)) {
                ModelState.AddModelError("", $"Something went wrong when deleting");
                return StatusCode(500, ModelState);
            }

            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult UpdatePostTitle(int id, [FromBody] PostUpdateTitleRequest payload) {
            if (payload.Title == null) {
                ModelState.AddModelError("", "Post title should not be empty");
                return StatusCode(404, ModelState);
            }

            if (!PostRepository.UpdateTitle(id, payload.Title)) {
                ModelState.AddModelError("", $"Something went wrong when set product capapcity {payload.Title}");
                return StatusCode(500, ModelState);
            }

            return Ok(id);
        }

    }
}
