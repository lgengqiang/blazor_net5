using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppExample.Data.ViewModel
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public string Office { get; set; }

        public string Role { get; set; }

        public override string ToString()
        {
            return $"{UserName} ({Email})";
        }
    }
}
