using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW_Blog_BE.DTOs
{
    public class RegisterDTO
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
    }
}
