using System;
using Blog.Domain.Entities;
using Blog.Domain.Interfaces;

namespace Blog.Application.Posts
{
    public class GetPostByIdUseCase
    {
        private readonly IPostRepository _postRepository;

        public GetPostByIdUseCase(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Post> ExecuteAsync(int id)
        {
            return await _postRepository.GetByIdAsync(id);
        }
    }
}

