using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTKD_Lesson04.Models
{
    public class LTKDCustomer
    {
        public int CustomerID {  get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth{ get; set; }
    }
}