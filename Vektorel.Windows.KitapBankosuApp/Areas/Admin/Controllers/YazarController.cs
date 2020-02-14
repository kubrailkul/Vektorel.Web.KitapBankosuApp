using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vektorel.Windows.KitapBankosuApp.Models;

namespace Vektorel.Windows.KitapBankosuApp.Areas.Admin.Controllers
{
   
    public class YazarController : Controller
    {
        KitapContext ctx = new KitapContext();
        // GET: Admin/Yazar
        public ActionResult Index()
        {
            YazarViewModel y = new YazarViewModel();
            y.Yazarlar = ctx.Yazarlar.ToList();
            return View(y);
        }


        [HttpGet]

        public ActionResult YazarEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarEkle(Yazar yz)
        {
            ctx.Yazarlar.Add(yz);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YazarDetay(int? id)
        {

            return View(ctx.Yazarlar.Find(id));
        }

        public ActionResult YazarSil(int? id)
        {
            Yazar yz = new Yazar();
            yz=ctx.Yazarlar.Find(id);

          ctx.Yazarlar.Remove(yz);
            ctx.SaveChanges();
            return RedirectToAction("Index");
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();

            }

        }
    }
}