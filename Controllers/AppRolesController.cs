using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace NIC_PROJECT.Controllers 
{
    [Authorize(Roles ="SuperAdmin")]
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager=roleManager;
        }

        //List all the Roles created by Users
        public IActionResult Index()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            //avoid duplicate role
            if(!roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("Index");
        }
    }
}
