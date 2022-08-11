using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrac
{
    public interface IUserService
    {
        List<OperationClaim>GetClaims(User user);
        void add(User user);
        User GetByMail(string mail);
    }
}
