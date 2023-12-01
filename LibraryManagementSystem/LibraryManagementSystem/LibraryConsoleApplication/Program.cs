
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;

public class Program
{


    private static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IMemberService, MemberManager>()
             .AddSingleton<IinMemoryMemberDal, InMemoryMemberDal>()
            .AddSingleton<IBookService, BookManager>()
             .AddSingleton<IinMemoryBookDal, InMemoryBookDal>()
            .AddSingleton<ILibraryService, LibraryManager>()
            .BuildServiceProvider();

        // Dependency Injection kullanarak servisi alın
        var memberService = serviceProvider.GetRequiredService<IMemberService>();
        var bookService = serviceProvider.GetRequiredService<IBookService>();
        var libraryService = serviceProvider.GetRequiredService<ILibraryService>();

        var member1 = new Member(1, "Kemal", "Odun", 181);
        var member2 = new Member(2, "İsmet", "Odun", 25);

        var book1 = new Book(1, "Suç ve Ceza", "Fyodor Dostoyevski", "671", 1866);
        var book2 = new Book(2, "1984", "George Orwell", "328", 1943);
        var book3 = new Book(3, "Küçük Prens", "Antonine", "93", 1943);


        Console.WriteLine("\n\n\n\n                 **** Members Tests ****");
        Console.WriteLine("     ---- List of members ----");
        var result = memberService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Firstname    :  {result[i].FirstName}  Surname     :  {result[i].LastName}  Member Number:     {result[i].MemberNum} ");
        }

        Console.WriteLine("\n     **** Adding member  ****");
        memberService.Add(member1);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of members ----\n\n");
        result = memberService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Firstname    :  {result[i].FirstName}  Surname     :  {result[i].LastName}  Member Number:     {result[i].MemberNum} ");
        }
        Console.WriteLine("\n     **** Updating member  ****");
        memberService.Update(member2);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of members ----\n\n");
        result = memberService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Firstname    :  {result[i].FirstName}  Surname     :  {result[i].LastName}  Member Number:     {result[i].MemberNum} ");
        }
        Console.WriteLine("\n     **** Deleting member  ****");
        memberService.Delete(3);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of members ----\n\n");
        result = memberService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Firstname    :  {result[i].FirstName}  Surname     :  {result[i].LastName}  Member Number:     {result[i].MemberNum} ");
        }
        Console.WriteLine("\n\n\n\n                 Books Tests ****");

        Console.WriteLine("\n     ---- List of books ----\n\n");
        var resultBook = bookService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Book Name    :  {resultBook[i].Name}  Author     :  {resultBook[i].Author}  Page Size:     {resultBook[i].PageSize} ");
        }
        Console.WriteLine("\n     **** Adding book  ****");
        bookService.Add(book1);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of books ----\n\n");
        resultBook = bookService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Book Name    :  {resultBook[i].Name}  Author     :  {resultBook[i].Author}  Page Size:     {resultBook[i].PageSize} ");
        }
        Console.WriteLine("\n     **** Deleted book  ****");
        bookService.Delete(3);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of books ----\n\n");
        resultBook = bookService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Book Name    :  {resultBook[i].Name}  Author     :  {resultBook[i].Author}  Page Size:     {resultBook[i].PageSize} ");
        }
        Console.WriteLine("\n     **** Updated book  ****");
        bookService.Update(book2);
        Console.WriteLine("     **** Updated list   ****\n\n");
        Console.WriteLine("\n     ---- List of books ----\n\n");
        resultBook = bookService.GetAll();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"    Book Name    :  {resultBook[i].Name}  Author     :  {resultBook[i].Author}  Page Size:     {resultBook[i].PageSize} ");
        }

        Console.WriteLine("\n     **** Barrow book  ****");
        libraryService.Barrow(2, 2);
        Console.WriteLine("\n     **** Return of book  ****");
        libraryService.ReturnBook(2, 2);




    }




}