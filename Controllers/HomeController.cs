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
        string UserName = "admin";
        string Password = "123456";

        public ActionResult Index()
        {
            // The Authentication is empty before the app runs
            ViewBag.Authentication = "";
            return View();
        }


        [HttpPost]
        public ActionResult Index(string userName , string password) // Our Login Function
        {
            if(userName.Length < 5 || password.Length < 5)  //Username or password if smaller than five.Then go if block.
            {
                if (userName.Length < 5)//Username smaller than five character
                {
                    ViewBag.Authentication = "Kullanıcı adi 5 karakterden kucuk olamaz"; //Authentication set the sentence
                    return View();
                }
                // if else
                ViewBag.Authentication = "Password 5 karakterden kucuk olamaz"; //Authentication set the sentence
                return View();
            }
            if (UserName == userName && Password == password) // If the username and password are entered correctly

            {
                ViewBag.Authentication = "Başarıyla Giriş Yaptınız."; //Authentication set the sentence
                return View();
            }
            // if else
            ViewBag.Authentication = "Kullanıcı adi veya şifre hatalıdır."; //Authentication set the sentence
            return View();
        }
        
    }
}