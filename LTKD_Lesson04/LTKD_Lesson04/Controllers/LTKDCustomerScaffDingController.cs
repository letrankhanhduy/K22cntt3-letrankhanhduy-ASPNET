using LTKD_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTKD_Lesson04.Controllers
{
    public class LTKDCustomerScaffDingController : Controller
    {

        private static List<LTKDCustomer> listCustomer = new List<LTKDCustomer>()
            {
                new LTKDCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Lê Trần",
                     LastName = "Khánh Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LTKDCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Ngô Hoàng",
                     LastName = "Minh",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LTKDCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Lê Hoàng",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new LTKDCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
        // GET: LTKDCustomerScaffDing
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult LTKDCreate()
        {
            var model = new LTKDCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult LTKDCreate(LTKDCustomer model)
        {
            listCustomer.Add(model);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult LTKDEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}