using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppExample.Data.ViewModel
{
    public class LoggedInUserViewModel
    {
        public string LoginName { get; set; }

        public string DisplayName { get; set; }

        public string Department { get; set; }

        public DateTime LoginTime { get; set; }

        public override string ToString()
        {
            return this.LoginName == this.DisplayName ? this.LoginName : $"{this.DisplayName} ({this.LoginName})";
        }
    }
}
