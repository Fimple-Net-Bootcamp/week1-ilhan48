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
    public class LibraryManager : ILibraryService
    {
        IinMemoryMemberDal _memberDal;
        IinMemoryBookDal _bookDal;
        public LibraryManager(IinMemoryMemberDal inMemoryMemberDal, IinMemoryBookDal bookDal)
        {
            _memberDal = inMemoryMemberDal;
            _bookDal = bookDal;

        }
        public void Barrow(int memberId, int bookId)
        {
            // Üye bulunur
            Member member = _memberDal.GetById(memberId);

            // Kitap bulunur
            Book book = _bookDal.GetById(bookId);

            // Eğer üye ve kitap bulunduysa ve kitap henüz ödünç alınmadıysa
            if (member != null && book != null && !member.BarrowedBooks.Contains(book))
            {
                // Kitabı ödünç alınan kitaplar listesine ekle
                member.BarrowedBooks.Add(book);
                Console.WriteLine($"{member.FirstName} {member.LastName} (ID: {member.Id}) borrowed the book: {book.Name}");
            }
            else
            {
                Console.WriteLine($"Member with ID {memberId} not found or Book with ID {bookId} not available or {member.FirstName} {member.LastName} already has this book.");
            }
        }

        public void ReturnBook(int memberId, int bookId)
        {
            // Üye bulunur
            Member member = _memberDal.GetById(memberId);

            // Kitap bulunur
            Book book = _bookDal.GetById(bookId);

            // Eğer üye ve kitap bulunduysa ve kitap ödünç alındıysa
            if (member != null && book != null && member.BarrowedBooks.Contains(book))
            {
                // Kitabı ödünç alınan kitaplar listesinden çıkar
                member.BarrowedBooks.Remove(book);
                Console.WriteLine($"{member.FirstName} {member.LastName} (ID: {member.Id}) returned the book: {book.Name}");
            }
            else
            {
                Console.WriteLine($"Member with ID {memberId} not found or Book with ID {bookId} not borrowed by {member.FirstName} {member.LastName}.");
            }
        }

    }
}
