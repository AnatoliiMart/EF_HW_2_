using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW_2.Models
{
    public class Press
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ничего не было введено")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Press() => Books = new List<Book>();

        public override string ToString() => $"{Name}";
    }
}
