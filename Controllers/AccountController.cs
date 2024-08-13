using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project.Controllers
{
    public class AccountController : Controller
    {

        MyDbContext entity = new MyDbContext();

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User identity)
        {

            bool userExist = entity.Users.Any(x => x.EMAIL == identity.EMAIL && x.PASSWORD == identity.PASSWORD);

            var user = entity.Users.FirstOrDefault(x => x.EMAIL == identity.EMAIL && x.PASSWORD == identity.PASSWORD);

            if (userExist)
            {
                CurrentUser.Email = user.EMAIL;
                CurrentUser.UserID = user.ID;
                FormsAuthentication.SetAuthCookie(user.EMAIL, false);
                return RedirectToAction("Index", "Calculator");
            }

            ModelState.AddModelError("", "Username or Password is wrong!");

            return View();
        }


        [HttpPost]
        public ActionResult SignIn(User info)
        {
            bool userExist = entity.Users.Any(x => x.EMAIL == info.EMAIL);

            if (userExist)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı zaten var");
            }

            else
            {
                entity.Users.Add(info);
                entity.SaveChanges();
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public ActionResult SignOut()
        {


            FormsAuthentication.SignOut();


            return RedirectToAction("Login", "Account");
        }

    }
}