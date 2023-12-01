using Entities.Concrete;

public partial class Program
{
    public class PrintableBook : Book, IPrintable
    {
        public PrintableBook(int id, string name, string author, string pageSize, int year) : base(id, name, author, pageSize, year)
        {
        }

        public void Print()
        {
            Console.WriteLine($"    Book Name    :  {Name}  Author     :  {Author}  Page Size:     {PageSize} ");
        }
    }




}