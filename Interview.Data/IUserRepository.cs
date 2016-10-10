using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data.Model;

namespace Interview.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
