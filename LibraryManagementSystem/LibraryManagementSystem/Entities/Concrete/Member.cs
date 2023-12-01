using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberNum { get; set; }
        public List<Book> BarrowedBooks { get; set; } = new List<Book>();

        public Member(int id, string firstName, string lastName, int memberNum, List<Book> barrowedBooks)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MemberNum = memberNum;
            BarrowedBooks = barrowedBooks;
        }

        public Member(int id, string firstName, string lastName, int memberNum)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MemberNum = memberNum;
        }
    }
}
