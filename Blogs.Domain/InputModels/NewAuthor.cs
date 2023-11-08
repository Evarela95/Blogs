using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domain.InputModels
{
    public class NewAuthor
    {
        public NewAuthor() { }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Alias")]
        public string Alias { get; set; }
    }
}
