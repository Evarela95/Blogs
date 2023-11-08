using Blogs.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.Entities
{
    public class Post : Entity
    {
        private Post() { }

        public Post(int authorId, string content, int? parentId = null)
        {
            AuthorId = authorId;
            Content = content;
            CreateDateTime = DateTime.Now;
            LastChangeDateTime = DateTime.Now;
            ParentId = parentId;
        }

        [Key]
        [Column("PostId")]
        public int Id { get; private set; }

        [ForeignKey("Author")]
        public int AuthorId { get; private set; }

        public Author Author { get; private set; }

        [MaxLength(200)]
        public string Content { get; private set; }

        public DateTime CreateDateTime { get; private set; }

        public DateTime LastChangeDateTime { get; private set; }

        [Column("ParentPostId")]
        public int? ParentId { get; private set; }

        [ForeignKey("ParentId")]
        public List<Post> Posts { get; private set; }

        public void Update(string content)
        {
            Content = content;
            LastChangeDateTime = DateTime.Now;
        }

        public PostDTO AsDTO()
        {
            return AsDTO(this);
        }

        public static PostDTO AsDTO(Post post)
        {
            return new PostDTO(post.Id, post.AuthorId, post.Content, post.ParentId);
        }
    }
}
