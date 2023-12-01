using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryMemberDal : IinMemoryMemberDal
    {
        public List<Member> _members;

        public InMemoryMemberDal()
        {
            _members = new List<Member>
            {
                new Member(1, "Ilhan", "Odun", 1),
                new Member(2, "Hasan", "Odun", 2),
                new Member(3, "Isa", "Odun", 3)
            };
        }



        public List<Member> GetAll() { return _members; }
        public void Add(Member member) { _members.Add(member); }
        public void Update(Member member)
        {
            Member memberToUpdate = _members.SingleOrDefault(m => m.Id == member.Id);
            memberToUpdate.FirstName = member.FirstName;
            memberToUpdate.LastName = member.LastName;
            memberToUpdate.MemberNum = member.MemberNum;
        }
        public void Delete(int id)
        {
            Member memberToDelete = _members.SingleOrDefault(member => member.Id == id);
            _members.Remove(memberToDelete);

        }

        public Member GetById(int id)
        {
            return _members.FirstOrDefault(member => member.Id == id);
        }
    }
}
