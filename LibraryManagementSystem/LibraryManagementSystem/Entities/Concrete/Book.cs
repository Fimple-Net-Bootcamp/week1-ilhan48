using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : Literature
    {
        public Book(int id, string name, string pageSize, string author, int yearOfPublication) { 
            this.Id = id;
            this.Name = name;
            this.PageSize = pageSize;
            this.Author = author;
            this.YearOfPublication = yearOfPublication;
        }
    }
}
