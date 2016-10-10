using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data;
using Interview.Data.Model;

namespace Interview.Data.Sql.Repositories
{
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Get All Users that have access to the system.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return GetAllByContext().ToList();

        }

        /// <summary>
        /// Cheat method to 'pretend' to be a database table
        /// </summary>
        /// <returns></returns>
        private IEnumerable<User> GetAllByContext()
        {
            List<User> users = new List<User>();
            users.Add(new User()
            {
                UserId = 1,
                FirstName = "Charlene",
                LastName = "Cunningham",
                Status = 1
            });

            users.Add(new User()
            {
                UserId = 2,
                FirstName = "Hazel",
                LastName = "Harper",
                Status = 2
            });

            users.Add(new User()
            {
                UserId = 3,
                FirstName = "Jon",
                LastName = "Robinson",
                Status = 1
            });

            users.Add(new User()
            {
                UserId = 4,
                FirstName = "Mildred",
                LastName = "Holt",
                Status = 2
            });

            users.Add(new User()
            {
                UserId = 5,
                FirstName = "Nathan",
                LastName = "Doyle",
                Status = 2
            });

            users.Add(new User()
            {
                UserId = 6,
                FirstName = "Billie",
                LastName = "Perez",
                Status = 3
            });

            users.Add(new User()
            {
                UserId = 7,
                FirstName = "Terence",
                LastName = "Barnes",
                Status = 1
            });

            users.Add(new User()
            {
                UserId = 8,
                FirstName = "Jaime",
                LastName = "Rodriquez",
                Status = 2
            });

            users.Add(new User()
            {
                UserId = 9,
                FirstName = "Matt",
                LastName = "Bennett",
                Status = 2
            });

            users.Add(new User()
            {
                UserId = 10,
                FirstName = "Cesar",
                LastName = "Dixon",
                Status = 3
            });


            return users;

        }
    }
}
