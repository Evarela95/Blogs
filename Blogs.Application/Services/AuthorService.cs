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
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;

        public AuthorService(IAuthorRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public AuthorDTO Get(int id)
        {
            var author = _repository.Get(s => s.Id == id);
            return author.AsDTO();
        }

        public List<AuthorDTO> List()
        {
            return _repository
                .GetAll()
                .ToList()
                .ConvertAll(author => author.AsDTO());
        }

        public bool Insert(NewAuthor newAuthor)
        {
            Author author = new Author(newAuthor.Alias);
            _repository.Insert(author);
            _repository.Save();
            return true;
        }

        public bool Update(ExistingAuthor existingAuthor)
        {
            Author author = _repository.Get(s => s.Id == existingAuthor.Id);
            author.Update(existingAuthor.Alias);
            _repository.Update(author);
            _repository.Save();
            return true;
        }

        public bool Delete(int id) 
        {
            Author author = _repository.Get(s => s.Id == id);
            _repository.Delete(author);
            _repository.Save();
            return true;
        }
    }
}
