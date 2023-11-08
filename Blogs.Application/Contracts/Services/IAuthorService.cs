using Blogs.Domain.DTOs;
using Blogs.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts
{
    public interface IAuthorService
    {
        AuthorDTO Get(int id);

        List<AuthorDTO> List();

        bool Insert(NewAuthor newAuthor);

        bool Update(ExistingAuthor existingAuthor);

        bool Delete(int id);


    }
}
