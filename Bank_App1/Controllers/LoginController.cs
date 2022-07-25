using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Bank_App1.Models;

namespace Bank_App1.Controllers
{
    public class LoginController : Controller
    {
        bankuserdbEntities dbhelper = new bankuserdbEntities();

        public ActionResult Signin()
        {
            return View("Signin");
        }
        public ActionResult AfterSignin ( UserTb userTb, String retrunURL)
        {
            foreach (var banker in dbhelper.UserTbs.ToList())
            {
                if (banker.Email == userTb.Email && banker.Password == userTb.Password)
                {
                    FormsAuthentication.SetAuthCookie(userTb.Email, false);
                    if (retrunURL != null)
                    {
                        return Redirect(retrunURL);
                    }
                    else
                    {
                        return Redirect("/Bank/Index");
                    }
                }
                else
                {
                    ViewBag.InvalidMessage = "User Email / Password is Incorrect";
                    return View("Signin");
                }
            }
            return View("Signin");
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home/Index");
        }
    }
}