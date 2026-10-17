using BookStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchbBook(string title,string Authorname)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(Authorname)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){ Id=1,Title="MVC",Author="Kanchan"},
                new BookModel(){ Id=2,Title="Java",Author="Umika"},
                new BookModel(){ Id=3,Title="C#",Author="Kajal"},
                new BookModel(){ Id=4,Title="ASP",Author="Rohit"},
                new BookModel(){ Id=5,Title=".Net",Author="Umesh"},
            };
        }
    }
}
