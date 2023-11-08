using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.InputModels
{
    public class NewPost
    {
        public int AuthorId { get; set; }

        public string Content { get; set; }

        public int ParentId { get; set; }
    }
}
