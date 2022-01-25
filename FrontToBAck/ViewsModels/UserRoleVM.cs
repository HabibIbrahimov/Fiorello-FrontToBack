using FrontToBAck.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.ViewsModels
{
    public class UserRoleVM
    {
        public AppUser AppUser;
        public IList<string> Roles;
    }
}
