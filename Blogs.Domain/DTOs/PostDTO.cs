using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.DTOs
{
    public class PostDTO
    {
        public PostDTO(int id, int authorId, string content, int? parentId = 0)
        {
            Id = id; 
            AuthorId = authorId;
            Content = content;
            ParentId = parentId;
        }

        public int Id { get; private set; }

        public int AuthorId { get; private set; }

        public string Content { get; private set; }

        public int? ParentId { get; private set; }
    }
}
