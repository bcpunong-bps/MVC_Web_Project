using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Web_Project.Context;
using MVC_Web_Project.Models;
using System.Web.Mvc;

namespace MVC_Web_Project.Controllers
{
    public class CustomerController: Controller
    {

        CustomerContext db = new CustomerContext();

        public ActionResult Index() 
        {
            ViewBag.Title = "Customer List";
            //var list = db.Customers.ToList();
            //var model = list.Select(c => new CustomerDTO
            //{
            //    CustID = c.CustID,
            //    CustName = c.CustName

            //}).ToList();

            //return View(model);





            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerDTO data)
        {
            var customer = new Customer
            {
                CustID = data.CustID,
                CustName = data.CustName,
             
            };

            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer model = new Customer();
            model = db.Customers.FirstOrDefault(x => x.CustID == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Customer data)
        {
            using (var db = new CustomerContext())
            {
                var entity = db.Customers.FirstOrDefault(x => x.CustID == data.CustID);
                db.Entry(entity).CurrentValues.SetValues(data);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Adds()
        {
            return View();
        }



    }
}