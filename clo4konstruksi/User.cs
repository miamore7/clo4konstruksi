using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clo4konstruksi
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // admin / user / SuperAdmin

        // TAMBAHKAN PROPERTI INI
        public bool IsActive { get; set; }
    }
}
