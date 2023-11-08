using Blogs.Domain.DTOs;
using Blogs.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts
{
    public interface IPostService
    {
        PostDTO Get(int id);

        List<PostDTO> List();

        bool Insert(NewPost newPost);

        bool Update(ExistingPost existingPost);

        bool Delete(int id);
    }
}
