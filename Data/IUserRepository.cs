using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auth.Models;

namespace DAW_Blog_BE.Data
{
    interface IUserRepository
    {
        User Create(User user);
    }
}
