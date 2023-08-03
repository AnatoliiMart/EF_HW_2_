using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EF_HW_2
{
    public partial class Form4 : Form
    {
        private MyLibraryEntities _db;
        private readonly Books _book;
        public Form4(Form1 form)
        {
            InitializeComponent();
            _book = form.GetOneBook();
            txtBox_BookName.Text = _book.Name;
            txtBox_PagesCount.Text = _book.PagesCount.ToString();
            txtBox_AuthorName.Text = _book.Authors.Name;
            txtBox_AuthorSurname.Text = _book.Authors.Surname;
            txtBox_CategoryName.Text = _book.Categories.Name;
            txtBox_PressName.Text = _book.Presses.Name;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (_db = new MyLibraryEntities())
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
                            item.Authors = getAuthor.FirstOrDefault();
                        else
                            item.Authors = new Authors() { Name = txtBox_AuthorName.Text, Surname = txtBox_AuthorSurname.Text };
                        if (getPress.FirstOrDefault() != null)
                            item.Presses = getPress.FirstOrDefault();
                        else
                            item.Presses = new Presses() { Name = txtBox_PressName.Text };
                        if (getCategory.FirstOrDefault() != null)
                            item.Categories = getCategory.FirstOrDefault();
                        else
                            item.Categories = new Categories() { Name = txtBox_CategoryName.Text };

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
