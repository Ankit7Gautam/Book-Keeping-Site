using Book_Keeping_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_Keeping_Site.Controllers
{
    public class BookController : Controller
    {
        BookDbEntities1 dbobj = new BookDbEntities1();
        // GET: Book
        public ActionResult Index()
        {
            var data = dbobj.tblBooks.ToList();
            return View(data);
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(tblBook Model)
        {
            tblBook tblobj=new tblBook();
            tblobj.Book_Name = Model.Book_Name;
            tblobj.Author_Name= Model.Author_Name;
            tblobj.Publisher= Model.Publisher;
            tblobj.Publication_Year= Model.Publication_Year;
            tblobj.Price= Model.Price;
            tblobj.Language= Model.Language;
            tblobj.ISBN_Number= Model.ISBN_Number;
            tblobj.Country_Origin= Model.Country_Origin;
            tblobj.Created_At= Model.Created_At;
            tblobj.Updated_At = Model.Updated_At;
            tblobj.Book_Description= Model.Book_Description;
            tblobj.Available_On=Model.Available_On;
            dbobj.tblBooks.Add(tblobj);
            dbobj.SaveChanges();
            TempData["message"] = "Data Inserted Successfuly";
            return RedirectToAction("Index");
            
        }

        public ActionResult Edit(int id)
        {
            var data = dbobj.tblBooks.Where(x => x.Id == id).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,tblBook model)
        {
            var data = dbobj.tblBooks.FirstOrDefault(x=>x.Id==id);
            if (data!= null)
            {
                data.Book_Name= model.Book_Name;
                data.Author_Name= model.Author_Name;
                data.Publisher= model.Publisher;
                data.Publication_Year= model.Publication_Year;
                data.Price= model.Price;
                data.Language= model.Language;
                data.ISBN_Number= model.ISBN_Number;
                data.Country_Origin= model.Country_Origin;
                data.Book_Description= model.Book_Description;
                data.Available_On= model.Available_On;
                data.Created_At= model.Created_At;
                data.Updated_At= model.Updated_At;
                dbobj.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data=dbobj.tblBooks.FirstOrDefault(x=>x.Id==id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,tblBook model)
        {
            var data = dbobj.tblBooks.FirstOrDefault(x => x.Id == id);
            if(data!=null)
            {
                dbobj.tblBooks.Remove(data);
                dbobj.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data=dbobj.tblBooks.FirstOrDefault(x=>x.Id== id);
            return View(data);
        }
    }
}