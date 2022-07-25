using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bank_App1.Models;

namespace Bank_App1.Controllers
{
    public class BankController : Controller
    {
        bankuserdbEntities dbhelper = new bankuserdbEntities();
        public ActionResult Index()
        {
            return View(dbhelper.UserTbs.ToList());
        }

        public ActionResult Approve(int id)
        {
            UserTb ctb = dbhelper.UserTbs.Find(id);
            ctb.Status = "Approved";
            dbhelper.SaveChanges();
            return Redirect("/Bank/Index");
        }
        public ActionResult Add()
        {
            return View("Add");
        }

        public ActionResult AfterAdd(UserTb Banker)
            {
                Banker.Status = "Pending";
                dbhelper.UserTbs.Add(Banker);
                dbhelper.SaveChanges();
                return Redirect("Index");
            }
            public ActionResult delete(int id)
            {
                UserTb ctb = dbhelper.UserTbs.Find(id);
                dbhelper.UserTbs.Remove(ctb);
                dbhelper.SaveChanges();
                return Redirect("/Bank/Index");
            }
        }
    }

