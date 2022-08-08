using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string StreetAddress { get; set; }

        public string State { get; set; }

        public string City { get; set; }    

        public string ZipCode  { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

    }
}
