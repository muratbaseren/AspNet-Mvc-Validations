using AspNetMvcValidations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcValidations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }

        [HttpPost]
        public ActionResult Index(Kullanici model)
        {
            //ModelState.IsValid

            if(model.KullaniciAdi == "murat")
            {
                // Veritabanından kullanıcı adı kullanılıyor mu kontrolü yaptınız varsayalım..
                ModelState.AddModelError("", "Bu kullanıcı adı kullanılıyor.");
            }

            return View(model);
        }
    }
}