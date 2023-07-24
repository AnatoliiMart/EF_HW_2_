using EF_HW_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_HW_2
{
    public partial class Form4 : Form
    {
        private MyDbContext _db;
        private readonly Book _book;
        public Form4(Form1 form)
        {
            InitializeComponent();
            _book = form.GetOneBook();
            txtBox_BookName.Text = _book.Name;
            txtBox_PagesCount.Text = _book.PagesCount.ToString();
            txtBox_AuthorName.Text = _book.Author.Name;
            txtBox_AuthorSurname.Text = _book.Author.Surname;
            txtBox_CategoryName.Text = _book.Category.Name;
            txtBox_PressName.Text = _book.Press.Name;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (_db = new MyDbContext())
            {
                foreach (var item in _db.Books.ToList())
                {
                    if (item.Id == _book.Id)
                    {
                        var getAuthor = from author in _db.Authors
                                        where author.Name.ToLower() == txtBox_AuthorName.Text.ToLower() && 
                                              author.Surname.ToLower() == txtBox_AuthorSurname.Text.ToLower()
                                        select author;

                        var getPress = from press in _db.Presses
                                       where press.Name.ToLower() == txtBox_PressName.Text.ToLower()
                                       select press;

                        var getCategory = from category in _db.Categories
                                          where category.Name.ToLower() == txtBox_CategoryName.Text.ToLower()
                                          select category;

                        if (getAuthor.FirstOrDefault() != null)
                            item.Author = getAuthor.FirstOrDefault();
                        else
                            item.Author = new Author() { Name = txtBox_AuthorName.Text, Surname = txtBox_AuthorSurname.Text };
                        if (getPress.FirstOrDefault() != null)
                            item.Press = getPress.FirstOrDefault();
                        else
                            item.Press = new Press() { Name = txtBox_PressName.Text };
                        if (getCategory.FirstOrDefault() != null)
                            item.Category = getCategory.FirstOrDefault();
                        else
                            item.Category = new Category() { Name = txtBox_CategoryName.Text };

                        item.Name = txtBox_BookName.Text;
                        item.PagesCount = int.Parse(txtBox_PagesCount.Text);

                        _db.SaveChanges();
                        break;
                    }
                }
            }
            Close();
        }
    }
}
