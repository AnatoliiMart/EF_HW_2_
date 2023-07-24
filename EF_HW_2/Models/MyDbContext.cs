using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EF_HW_2.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("LibraryDb") { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Press> Presses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public void AddBook(string bookName, int bookPagesCount, string authorName, 
                            string authorSurname, string categoryName, string pressName)
        {
            Book book = new Book() { Name = bookName, PagesCount = bookPagesCount };

            var getAuthor = from author in Authors
                            where author.Name.ToLower() == authorName.ToLower() && author.Surname.ToLower() == authorSurname.ToLower()
                            select author;
            var getPress = from press in Presses
                           where press.Name.ToLower() == pressName.ToLower()
                           select press;
            var getCategory = from category in Categories
                              where category.Name.ToLower() == categoryName.ToLower()
                              select category;
            if (getAuthor.FirstOrDefault() != null)
                book.Author = getAuthor.FirstOrDefault();
            else
                book.Author = new Author() { Name = authorName, Surname = authorSurname };
            if (getPress.FirstOrDefault() != null)
                book.Press = getPress.FirstOrDefault();
            else
                book.Press = new Press() {  Name = pressName };
            if (getCategory.FirstOrDefault() != null)
                book.Category = getCategory.FirstOrDefault();
            else
                book.Category = new Category() {  Name = categoryName };

            Books.Add(book);
            SaveChanges();
        }

        public List<Book> SearchByAuthor(string authorName)
        {
            Author author = Authors.Where(a => a.Name.ToLower() == authorName.ToLower()).FirstOrDefault();
            List<Book> books = new List<Book>();
            if (author != null)
            { 
                Entry(author).Collection("Books").Load();
                foreach (var item in author.Books) 
                    books.Add(item);
            }
            return books;
        }

        public List<Book> SearchByBookName(string bookName)
        {
            var res = from b in Books
                      where b.Name.ToLower() == bookName.ToLower()
                      select b;
            return res.ToList();
        }

        public List<Book> SearchByCategory(string categoryName)
        {
            Category category = Categories.Where(a => a.Name.ToLower() == categoryName.ToLower()).FirstOrDefault();
            List<Book> books = new List<Book>();
            if (category != null)
            {
                Entry(category).Collection("Books").Load();
                foreach (var item in category.Books)
                    books.Add(item);
            }
            return books;
        }

        public List<Book> SearchByPressName(string pressName)
        {
            Press press = Presses.Where(a => a.Name.ToLower() == pressName.ToLower()).FirstOrDefault();
            List<Book> books = new List<Book>();
            if (press != null)
            {
                Entry(press).Collection("Books").Load();
                foreach (var item in press.Books)
                    books.Add(item);
            }
            return books;
        }
    }
}
