using Entities.Concrete;

public partial class Program
{
    public class PrintableMember : Member, IPrintable
    {
        public PrintableMember(int id, string firstName, string lastName, int memberNum) : base(id, firstName, lastName, memberNum)
        {
        }

        public void Print()
        {
            Console.WriteLine($"    Firstname    :  {FirstName}  Surname     :  {LastName}  Member Number:     {MemberNum} ");
        }
    }




}