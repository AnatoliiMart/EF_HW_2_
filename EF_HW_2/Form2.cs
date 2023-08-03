using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_HW_2
{
    public partial class Form2 : Form
    {
        private MyLibraryEntities _db;
        public Form2(Form1 form)
        {
            InitializeComponent();
            using (_db = new MyLibraryEntities()) 
            {
                cmbBox_SelectAuthor.DataSource = _db.Authors.ToList();
                cmbBox_SelectCategory.DataSource = _db.Categories.ToList();
                cmbBox_SelectPress.DataSource = _db.Presses.ToList();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (_db = new MyLibraryEntities())
                _db.AddBook(txtBox_BookName.Text, int.Parse(txtBox_PagesCount.Text), txtBox_AuthorName.Text,
                            txtBox_AuthorSurname.Text, txtBox_CategoryName.Text, txtBox_PressName.Text);
            Close();
        }

        private void cmbBox_SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categories category = cmbBox_SelectCategory.SelectedItem as Categories;
            txtBox_CategoryName.Text = category.Name;
        }

        private void cmbBox_SelectAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Authors author = cmbBox_SelectAuthor.SelectedItem as Authors;
            txtBox_AuthorName.Text = author.Name;
            txtBox_AuthorSurname.Text = author.Surname;
        }

        private void cmbBox_SelectPress_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Presses press = cmbBox_SelectPress.SelectedItem as Presses;
            txtBox_PressName.Text = press.Name;
        }
    }
}
