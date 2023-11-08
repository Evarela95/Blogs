using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.DTOs
{
    public   class AuthorDTO
    {
        public AuthorDTO(int id, string alias) 
        { 
            Id = id;
            Alias = alias;
            
        }

        public int Id { get; private set; }

        public string Alias { get; private set; }

      public string alias1()
        { return Alias; }


     }
}
