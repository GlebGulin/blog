using Blog.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }
        public UserViewModel(User row)
        {
            Id = row.Id;
            Name = row.Name;
            Pass = row.Pass;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string PassCoFirm { get; set; }
    }
}
