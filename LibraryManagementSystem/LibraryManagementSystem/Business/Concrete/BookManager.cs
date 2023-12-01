using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IinMemoryBookDal _inMemoryBookDal;

        public BookManager(IinMemoryBookDal inMemoryBookDal) {
            _inMemoryBookDal = inMemoryBookDal;

        }
        public void Add(Book book)
        {
            _inMemoryBookDal.Add(book);
        }

        public void Delete(int id)
        {
            _inMemoryBookDal.Delete(id);
        }

        public List<Book> GetAll()
        {
            return _inMemoryBookDal.GetAll();
        }
        public void Update(Book book)
        {
            _inMemoryBookDal.Update(book);
        }
    }
}
