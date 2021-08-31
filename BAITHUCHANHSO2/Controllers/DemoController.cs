using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap2.models;

namespace BAITHUCHANHSO2.Controllers
{
    public class DemoController : Controller
    {
        Giaiphuongtrinh Gtp = new Giaiphuongtrinh()
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinhtong(string soA, string soB)
        {
            int Sothunhat = Convert.ToInt32(soA);
            int Sothuhai = Convert.ToInt32(SoB);
            int Tonghaiso = Gtp.TinhTong(Sothunhat, Sothuhai);
            ViewBag.Tong = Tonghaiso;
            return View()
        }
     }
}