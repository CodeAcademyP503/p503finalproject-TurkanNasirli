using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Yekun_JobStore.Areas.Admin.Controllers;
using Yekun_JobStore.Infrastructure;
using Yekun_JobStore.Models;
using Yekun_JobStore.Models.ViewModels;

namespace Yekun_JobStore.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly JobstoreDbContext _jobstoreDbContext;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, JobstoreDbContext jobstoreDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jobstoreDbContext = jobstoreDbContext;
        }


        [HttpGet]
        public IActionResult Registerfor_jsk()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Registerfor_adv()
        {

            return View();
        }

        [HttpGet]
        public IActionResult RegisterAdmin()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registerfor_jsk(RegisterModel_s registerModel_s)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(registerModel_s.Email);
                if (appUser != null)
                {
                    ModelState.AddModelError("", "This user already exists");
                }
                else
                {
                    appUser = registerModel_s;

                    #region User and it's role creation witrh transaction
                    if (await this.RegisterUserAsync(registerModel_s, appUser))
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    #endregion
                }
                return View();
            }
           
            return View();
        }

        private async Task<bool>  RegisterUserAsync(RegisterModel_s registerModel_s, AppUser appUser)
        {
            bool isRegistered = false;

            using (IDbContextTransaction dbContextTransaction = _jobstoreDbContext.Database.BeginTransaction())
            {
                try
                {

                    IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerModel_s.Password);


                    if (identityResult.Succeeded)
                    {
                        IdentityResult identityRoleResult = await _userManager.AddToRoleAsync(appUser, RoleType.sUser.ToString());

                        if (identityRoleResult.Succeeded)
                        {
                            dbContextTransaction.Commit();
                            isRegistered = true;
                        }
                        else
                        {
                            dbContextTransaction.Rollback();
                            this.AddToModelErrors(identityResult.Errors);
                        }

                    }
                    else
                    {
                        this.AddToModelErrors(identityResult.Errors);
                        dbContextTransaction.Rollback();

                    }
                }
                catch (Exception exp)
                {
                    dbContextTransaction.Rollback();
                    ModelState.AddModelError("", exp.Message);
                }
            }

            return isRegistered;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registerfor_adv(RegisterModel_a registerModel_a)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(registerModel_a.Email);
                if (appUser != null)
                {
                    ModelState.AddModelError("", "This user already exists");
                }
                else
                {
                    appUser = registerModel_a;

                    #region User and it's role creation witrh transaction
                    if (await this.RegisterUserAsync(registerModel_a, appUser))
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    #endregion
                }
                return View();
            }

            return View();
        }

        private async Task<bool> RegisterUserAsync(RegisterModel_a registerModel_a, AppUser appUser)
        {
            bool isregistered_a = false;

            using (IDbContextTransaction dbContextTransaction = _jobstoreDbContext.Database.BeginTransaction())
            {
                try
                {

                    IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerModel_a.Password);


                    if (identityResult.Succeeded)
                    {
                        IdentityResult identityRoleResult = await _userManager.AddToRoleAsync(appUser, RoleType.aUser.ToString());

                        if (identityRoleResult.Succeeded)
                        {
                            dbContextTransaction.Commit();
                            isregistered_a = true;
                        }
                        else
                        {
                            dbContextTransaction.Rollback();
                            this.AddToModelErrors(identityResult.Errors);
                        }

                    }
                    else
                    {
                        this.AddToModelErrors(identityResult.Errors);
                        dbContextTransaction.Rollback();

                    }
                }
                catch (Exception exp)
                {
                    dbContextTransaction.Rollback();
                    ModelState.AddModelError("", exp.Message);
                }
            }

            return isregistered_a;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterAdmin(AdminRegisterModel adminRegisterModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(adminRegisterModel.Email);
                if (appUser != null)
                {
                    ModelState.AddModelError("", "This user already exists");
                }
                else
                {
                    appUser = adminRegisterModel;

                    #region User and it's role creation witrh transaction
                    if (await this.RegisterUserAsync(adminRegisterModel, appUser))
                        return RedirectToAction(nameof(AdminHomeController.AdminIndex), "AdminHome");
                    #endregion
                }
                return View();
            }

            return View();
        }

        private async Task<bool> RegisterUserAsync(AdminRegisterModel adminRegisterModel, AppUser appUser)
        {
            bool isRegisteredAdmin = false;
            using (IDbContextTransaction dbContextTransaction = _jobstoreDbContext.Database.BeginTransaction())
            {
                try
                {

                    IdentityResult identityResult = await _userManager.CreateAsync(appUser, adminRegisterModel.Password);


                    if (identityResult.Succeeded)
                    {
                        IdentityResult identityRoleResult = await _userManager.AddToRoleAsync(appUser, RoleType.admin.ToString());

                        if (identityRoleResult.Succeeded)
                        {
                            dbContextTransaction.Commit();
                            isRegisteredAdmin = true;
                        }
                        else
                        {
                            dbContextTransaction.Rollback();
                            this.AddToModelErrors(identityResult.Errors);
                        }

                    }
                    else
                    {
                        this.AddToModelErrors(identityResult.Errors);
                        dbContextTransaction.Rollback();

                    }
                }
                catch (Exception exp)
                {
                    dbContextTransaction.Rollback();
                    ModelState.AddModelError("", exp.Message);
                }
            }

            return isRegisteredAdmin;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Models.ViewModels.LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //get current user by email
                AppUser currentUser = await _userManager.FindByEmailAsync(loginModel.Email);

                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(currentUser, loginModel.Password, loginModel.RememberMe, true);
                if (signInResult.Succeeded)
                {                  
                    var user = User;
                    AdminRegisterModel adminRegisterModel = new AdminRegisterModel();
                    RegisterModel_a registerModel_A = new RegisterModel_a();
                    RegisterModel_s registerModel_S = new RegisterModel_s();
                    if (currentUser.Email == adminRegisterModel.Email)
                    {
                        return RedirectToAction("AdminIndex", "AdminHome", new { area = "Admin" });
                    }
                    else if (currentUser.Email==registerModel_A.Email||currentUser.Email==registerModel_S.Email)
                    {

                        return RedirectToAction("Index", "Home");
                    }
                    //go to user defined role panel

                }
                else
                    if (signInResult.IsLockedOut)
                {
                    ModelState.AddModelError("", "This use is already locked out!!");
                }
                else
                    if (signInResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Your have no access");
                }

            }
            return RedirectToAction(nameof(Login));
        }

      
    }


}
