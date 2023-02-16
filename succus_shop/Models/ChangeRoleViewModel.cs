using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace succus_shop.Models
{
    public class ChangeRoleViewModel 
    {
        public UserModel User { get; set; }
        public RoleModel Role { get; set; }

    }
}
