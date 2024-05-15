using LTKD_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTKD_Lesson04.Controllers
{
    public class LTKDCustomerController : Controller
    {
        // GET: LTKDCustomer
        public ActionResult Index()
        {
            return View();
        }

        //Action: LTKDCustomerDetails
        public ActionResult LTKDCustomerDetails()
        {
            //tạo đối tượng trong dữ liệu 
            var customer = new LTKDCustomer()
            {
                CustomerID = 1,
                FirstName = "Lê Trần",
                LastName = "Khánh Duy",
                Address = "K22CNT3",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult LTKDlistCustomer()
        {
            var list = new List<LTKDCustomer>()
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
            ViewBag.list = list;
            return View();
        }
    }
}