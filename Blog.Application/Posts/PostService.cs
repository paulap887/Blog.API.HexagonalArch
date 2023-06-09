using System;
using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Application.Posts
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task CreatePostAsync(Post post)
        {
            // Validate the post and perform any other necessary operations
            await _postRepository.AddAsync(post);
        }
    }
}

