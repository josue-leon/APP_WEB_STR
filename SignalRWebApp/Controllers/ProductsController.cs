using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using SignalRWebApp.Models;
using SignalRWebApp.SqlServerNotifier;

namespace SignalRWebApp.Controllers {
    public class ProductsController : Controller
    {
        private SignaRTestContext db = new SignaRTestContext();
        
        public async Task<ActionResult> Index()
        {
            var collection = db.Products;
            ViewBag.NotifierEntity = db.GetNotifierEntity<Product>(collection).ToJson();
            return View(await collection.ToListAsync());
        }

        public async Task<ActionResult> IndexPartial()
        {
            var collection = db.Products;
            ViewBag.NotifierEntity = db.GetNotifierEntity<Product>(collection).ToJson();
            return PartialView(await collection.ToListAsync());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
