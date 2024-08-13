using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.Reflection;
using Project.Models;


namespace Project.Controllers
{

    
    [Authorize]
    public class CalculatorController : Controller
    {
        MyDbContext _db = new MyDbContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double FIRST_NUMBER, double SECOND_NUMBER, string OPERATION)
        {
            double result = 0.0;


            switch (OPERATION)
            {
                case "+":
                    result = FIRST_NUMBER + SECOND_NUMBER;
                    break;
                case "-":
                    result = FIRST_NUMBER - SECOND_NUMBER;
                    break;
                case "*":
                    result = FIRST_NUMBER * SECOND_NUMBER;
                    break;
                case "/":
                    result = FIRST_NUMBER / SECOND_NUMBER;
                    break;
            }

            

            _db.Results.Add(new Result
            {
                FIRST_NUMBER = FIRST_NUMBER,
                SECOND_NUMBER = SECOND_NUMBER,
                OPERATION = OPERATION,
                RESULT = result,
                UserID = CurrentUser.UserID
            });

            _db.SaveChanges();

            @ViewData["Result"] = result;

            return View();
        }

    }
}