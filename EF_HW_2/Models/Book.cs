using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW_2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ничего не было введено")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ничего не было введено")]
        public int PagesCount { get; set; }

        public virtual Author Author { get; set; }
        public virtual Press Press { get; set; }
        public virtual Category Category { get; set; }

        public override string ToString() => $"Book name: {Name}\t\tPages count: {PagesCount}\t{Author}\tPress: {Press}\tCategory: {Category}";
    }
}
