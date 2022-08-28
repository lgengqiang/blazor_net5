using BlazorServerAppExample.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppExample.Data
{
    public class UserService
    {
        public Task<UserViewModel[]> GetUsers()
        {
            var result = new List<UserViewModel>();
            result.Add(new UserViewModel
            {
                UserName = "Andy Fixter",
                Email = "afixter@example.com",
                Department = "Sales",
                Office = "Shanghai",
                Role = "Sale",
            });
            result.Add(new UserViewModel
            {
                UserName = "Barry Jones",
                Email = "bjones@example.com",
                Department = "HRBP",
                Office = "Beijing",
                Role = "HR",
            });
            result.Add(new UserViewModel
            {
                UserName = "Tom King",
                Email = "tking@example.com",
                Department = "Software R&D",
                Office = "Guangdong",
                Role = "Developer",
            });
            return Task.FromResult(result.ToArray());
        }
    }
}
