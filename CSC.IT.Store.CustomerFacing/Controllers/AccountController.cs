using CSC.Core.Common.Identity;
using CSC.IT.Store.ViewModels.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CSC.IT.Store.CustomerFacing.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser, string> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser, string> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {


                var applicationUser = new ApplicationUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    Email = model.Email,
                    UserName = model.UserName
                };


                var creationResult = await _userManager.CreateAsync(applicationUser, model.Password);
                if (creationResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, creationResult.Errors.FirstOrDefault());
            }
            return View(model);
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignIn(SignInViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, shouldLockout: true);
                switch (signInResult)
                {
                    case SignInStatus.Success:
                        if (!string.IsNullOrWhiteSpace(returnUrl))
                            return Redirect(returnUrl);
                        else
                            return RedirectToAction("Index", "Home");

                    case SignInStatus.LockedOut:
                        return RedirectToAction("LockedOut");

                    case SignInStatus.RequiresVerification:
                        return RedirectToAction("RequiresVerification");

                    case SignInStatus.Failure:
                        ModelState.AddModelError(string.Empty, "Invalid user name and password");
                        break;

                    default:
                        ModelState.AddModelError(string.Empty, "Oops! Something went wrong.");
                        break;
                }
            }
            return View(model);
        }

        public ActionResult SignOut()
        {
            Request.GetOwinContext().Authentication.SignOut();
            return RedirectToAction("SignIn");
        }

    }
}
