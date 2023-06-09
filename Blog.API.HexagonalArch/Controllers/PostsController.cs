using System;
using Blog.Application.Posts;
using Blog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.HexagonalArch.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly GetPostByIdUseCase _getPostByIdUseCase;
        private readonly PostService _postService;

        public PostsController(GetPostByIdUseCase getPostByIdUseCase, PostService postService)
        {
            _getPostByIdUseCase = getPostByIdUseCase;
            _postService = postService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> Get(int id)
        {
            var post = await _getPostByIdUseCase.ExecuteAsync(id);
            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Post post)
        {
            await _postService.CreatePostAsync(post);
            return CreatedAtAction(nameof(Get), new { id = post.Id }, post);
        }

        // Other actions...
    }

}

