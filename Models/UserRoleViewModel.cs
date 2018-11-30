using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel() { }
        public UserRoleViewModel(ApplicationRole role, ApplicationUser user)
        {
            roleId = role.Id;
            roleName = role.Name;
            userId = user.Id;
            userName = user.UserName;
            
        }



        public string roleId { get; set; }
        public string roleName { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }

    }
}