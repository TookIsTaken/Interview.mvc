using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data.Model;

namespace Interview.Domain.Contracts
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
    }
}
