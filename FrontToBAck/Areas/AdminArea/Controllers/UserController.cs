using FrontToBAck.Models;
using FrontToBAck.ViewsModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBAck.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(
            UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index(string name)
        {

            var users = name == null ? _userManager.Users.ToList() :
                _userManager.Users.Where(u => u.FullName.ToLower().Contains(name.ToLower())).ToList();
            //List<UserReturnVM> userReturnVM = new List<UserReturnVM>();
            //foreach (var user in users)
            //{
            //    UserReturnVM userReturn = new UserReturnVM();
            //    userReturn.FullName = user.FullName;
            //    userReturn.Email = user.Email;
            //    userReturn.UserName = user.UserName;
            //    userReturn.Role=(await _userManager.GetRolesAsync(user))[0]
            //    userReturnVM.Add(userReturn);
            //}
            return View(users);
        }
        
        
        public async Task<IActionResult> Detail(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            UserRoleVM userRoleVM = new UserRoleVM();
            userRoleVM.AppUser = user;
            userRoleVM.Roles = await _userManager.GetRolesAsync(user);
            return View(userRoleVM);
        }


    }
}
