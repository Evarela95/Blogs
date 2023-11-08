using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.InputModels
{
    public class ExistingAuthor
    {
        public ExistingAuthor() { }

        public int Id { get; set; }

        public string Alias { get; set; }
    }
}
