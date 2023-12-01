using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IinMemoryMemberDal
    {
        List<Member> GetAll();
        Member GetById(int id);
        void Add(Member member);
        void Delete(int id);
        void Update(Member member);
    }
}
