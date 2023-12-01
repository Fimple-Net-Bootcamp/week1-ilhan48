
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.Concrete
{
    public class Literature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PageSize { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }



    }
}
