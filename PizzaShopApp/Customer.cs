using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopApp
{
    public class Customer
    {
        [Key]

        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreeAddress { get; set; }

        public string State { get; set; }

        public string city { get; set; }    

        public string ZipCode  { get; set; }

        public string EmailAddress { get; set; }

    }
}
