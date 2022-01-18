using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auth.Data;
using auth.Models;

namespace DAW_Blog_BE.Data
{
    public class UserRepository: IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            user.Id = _context.SaveChanges();
            return user;
        }
    }
}
