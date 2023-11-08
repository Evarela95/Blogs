using Blogs.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.Entities
{
    public class Author : Entity
    {
        private Author() { }

        public Author(string alias)
        {
            Alias = alias;
        }

        [Column("AuthorId")]
        public int Id { get; private set; }

        [MaxLength(50)]
        public string Alias { get; private set; }

        public void Update(string alias) 
        { 
            Alias = alias;
        }

        public AuthorDTO AsDTO() 
        { 
            return AsDTO(this); 
        }

        public static AuthorDTO AsDTO(Author author)
        { 
            return new AuthorDTO(author.Id, author.Alias);
        }
    }
}
