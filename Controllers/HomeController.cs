using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        // Describe the username and password
        string userNameGlobal = "admin";
        string passwordGlobal = "123456";

        public ActionResult Index()
        {
            // The Authentication is empty before the app runs
            ViewBag.Authentication = "";
            return View();
        }


        [HttpPost]
        public ActionResult Index(string userName , string password) // Our Login Function
        {
            if(userName.Length < 5)//Username smaller than five character
            {
                ViewBag.Authentication = "The username can not be less than 5 characters"; //Authentication set the sentence
                return View();
            }
            if(password.Length < 5)
            {
                ViewBag.Authentication = "The password can not bee less than 5 characters"; //Authentication set the sentence
                return View();
            }
            
            if (userNameGlobal == userName && passwordGlobal == password) // If the username and password are entered correctly

            {
                ViewBag.Authentication = "Succesfully sign in"; //Authentication set the sentence
                return View();
            }
            // if else
            ViewBag.Authentication = "The username or password are incorrect"; //Authentication set the sentence
            return View();
        }
    }
}