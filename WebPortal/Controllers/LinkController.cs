using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPortal.Models;

namespace WebPortal.Controllers
{
    public class LinkController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Link
        public async Task<ActionResult> Index()
        {
            return View(await db.Link.ToListAsync());
        }

        // GET: Link/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = await db.Link.FindAsync(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // GET: Link/Create
        public ActionResult Create()
        {
            /*Link emp = new Link();
            //sort the Link and get the last insert Link.
            var lastlink = db.Link.OrderByDescending(c => c.LinkID).FirstOrDefault();
            if (lastlink == null)
            {
                emp.LinkID = "BICS SFDC001";
            }
            else
            {
                //using string substring method to get the number of the last inserted employee's EmployeeID 
                emp.LinkID = "BICS SFDC" + (Convert.ToInt32(lastlink.LinkID.Substring(9, lastlink.LinkID.Length - 9)) + 1).ToString("D3");
            }*/
            return View();
        }

        // POST: Link/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LinkID,URL,LinkName")] Link link)
        {
            if (ModelState.IsValid)
            {
                db.Link.Add(link);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(link);
        }

        // GET: Link/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = await db.Link.FindAsync(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // POST: Link/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LinkID,URL,LinkName")] Link link)
        {
            if (ModelState.IsValid)
            {
                db.Entry(link).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(link);
        }

        // GET: Link/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = await db.Link.FindAsync(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // POST: Link/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Link link = await db.Link.FindAsync(id);
            db.Link.Remove(link);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
