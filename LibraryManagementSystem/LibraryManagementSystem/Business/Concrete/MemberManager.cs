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
    public class MemberManager : IMemberService
    {
        private readonly IinMemoryMemberDal _memberDal;

        public MemberManager(IinMemoryMemberDal inMemoryMember)
        {
            _memberDal = inMemoryMember;
        }

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }

        public void Delete(int id)
        {
            _memberDal.Delete(id);
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        public void Update(Member member)
        {
            _memberDal.Update(member);
        }

        public Member GetById(int id)
        {
            return _memberDal.GetById(id);
        }
    }
}
