using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using systemBuy.Models;

namespace systemBuy.Controllers
{
    public class billsController : Controller
    {
        private systemBuyContext db = new systemBuyContext();

        // GET: bills
        public ActionResult Index()
        {
            return View(db.bills.ToList());
        }

        // GET: bills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bills bills = db.bills.Find(id);


         
            if (bills == null)
            {
                return HttpNotFound();
            }
            //Session["iditems"] = id;

            return View(bills);
        }

        // GET: bills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,NameBuy,billNumber,DateBill,theReviewDate")] bills bills)
        {
            if (ModelState.IsValid)
            {
                db.bills.Add(bills);
                db.SaveChanges();
                Session["idBill"] = bills.id;
                return RedirectToAction("Create", "items");
            }

            return View(bills);
        }

        // GET: bills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bills bills = db.bills.Find(id);
            //var result = from bill in db.bills
            //             join item in db.items
            //             on bill.id equals item.Itembills_id
            //             where bill.id == id
            //             select bill;
            //var group = from b in result
            //            group b by b.item.
            //           into gr
            //            select new itrationsBills
            //            {
            //                dateTime=gr.Key,
            //                items = gr
            //            };
           
            if (bills == null)
            {
                return HttpNotFound();
            }
            return View(bills);
        }

        // POST: bills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,NameBuy,billNumber,DateBill,theReviewDate")] bills bills)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bills).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bills);
        }

        // GET: bills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bills bills = db.bills.Find(id);
            if (bills == null)
            {
                return HttpNotFound();
            }
            return View(bills);
        }

        // POST: bills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bills bills = db.bills.Find(id);
            db.bills.Remove(bills);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult invoice()
        {
            var id = (int)Session["iditems"];
            //var result = from i in db.items
            //             join b in db.bills
            //             on i.Itembills_id equals b.id
            //             where b.id == id
            //             select i;
            //var itemGroups = from r in result
            //                 group r by r.bills.NameBuy
            //               into gr
            //                 select new itrationsBills
            //                 {
            //                     NameBuy = gr.Key,
            //                     items = gr
            //                 };
            var result = from i in db.items
                         where i.Itembills_id == id
                         select i;
            //var result = db.items.Where(a => a.Itembills_id == id);

            return View(result);
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
