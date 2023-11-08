using Blogs.Application.Contracts;
using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.DTOs;
using Blogs.Domain.Entities;
using Blogs.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository)
        {
            this._repository = repository;
        }

        public PostDTO Get(int id)
        {
            var post = _repository.Get(s => s.Id == id);
            return post.AsDTO();
        }

        public List<PostDTO> List()
        {
            return _repository
                .GetAll(s => s.ParentId == null,
                    includes: i => i.Posts).ToList()
                .ConvertAll(post => post.AsDTO());
        }

        public bool Insert(NewPost newPost)
        {
            Post post = new Post(newPost.AuthorId, newPost.Content, newPost.ParentId);
            _repository.Insert(post);
            _repository.Save();
            return true;
        }

        public bool Update(ExistingPost existingPost)
        {
            Post post = _repository.Get(s => s.Id == existingPost.Id);
            post.Update(existingPost.Content);
            _repository.Update(post);
            _repository.Save();
            return true;
        }

        public bool Delete(int id)
        {
            Post post = _repository.Get(s => s.Id == id);
            _repository.Delete(post);
            _repository.Save();
            return true;
        }
    }
}
