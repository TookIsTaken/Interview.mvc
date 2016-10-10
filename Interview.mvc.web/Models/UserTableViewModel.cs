using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interview.Data.Model;

namespace Interview.mvc.web.Models
{
    public class UserTableViewModel
    {
        public IEnumerable<User> Users { get; set; }
    }
}