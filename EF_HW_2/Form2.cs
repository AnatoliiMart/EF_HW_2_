using EF_HW_2.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_HW_2
{
    public partial class Form2 : Form
    {
        private MyDbContext _db;
        public Form2(Form1 form)
        {
            InitializeComponent();
            using (_db = new MyDbContext()) 
            {
                cmbBox_SelectAuthor.DataSource = _db.Authors.ToList();
                cmbBox_SelectCategory.DataSource = _db.Categories.ToList();
                cmbBox_SelectPress.DataSource = _db.Presses.ToList();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (_db = new MyDbContext())
                _db.AddBook(txtBox_BookName.Text, int.Parse(txtBox_PagesCount.Text), txtBox_AuthorName.Text,
                            txtBox_AuthorSurname.Text, txtBox_CategoryName.Text, txtBox_PressName.Text);
            Close();
        }

        private void cmbBox_SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = cmbBox_SelectCategory.SelectedItem as Category;
            txtBox_CategoryName.Text = category.Name;
        }

        private void cmbBox_SelectAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author author = cmbBox_SelectAuthor.SelectedItem as Author;
            txtBox_AuthorName.Text = author.Name;
            txtBox_AuthorSurname.Text = author.Surname;
        }

        private void cmbBox_SelectPress_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Press press = cmbBox_SelectPress.SelectedItem as Press;
            txtBox_PressName.Text = press.Name;
        }
    }
}
