using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Data.Model
{
    public class User
    {
        // <summary>
        /// Gets or sets the identifier for the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's account status
        /// 1 -> Valid
        /// 2 -> Disabled
        /// 3 -> Closed
        /// </summary>
        public int Status { get; set; }    
    }
    
}
