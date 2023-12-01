using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DataAccess.Concrete
{
    public class InMemoryBookDal : IinMemoryBookDal
    {
        public List<Book> _books;

        public InMemoryBookDal()
        {
            _books = new List<Book>
            {
                new Book(1, "Suç ve Ceza", "Fyodor Dostoyevski", "671", 1866),
                new Book(2, "1984", "George Orwell", "328", 1943),
                new Book(3, "Küçük Prens", "Antonine", "93", 1943)
            };
        }

        public List<Book> GetAll() { return _books; }
        public void Add(Book book) { _books.Add(book); }
        public void Update(Book book)
        {
            Book bookToUpdate = _books.SingleOrDefault(b => b.Id == book.Id);
            bookToUpdate.Name = book.Name;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PageSize = book.PageSize;
            bookToUpdate.YearOfPublication = book.YearOfPublication;
        }
        public void Delete(int id)
        {
            Book booktoDelete = _books.SingleOrDefault(book => book.Id == id);
            _books.Remove(booktoDelete);
        }

        public Book GetById(int id)
        {
            return _books.FirstOrDefault(book => book.Id == id);
        }
    }
}
