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
        /// <summary>
        /// An auto generated number assigned to a customer
        /// </summary>
        [Key]
        public int CustomerID { get; set; }

        /// <summary>
        /// Customers legal First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Customers legal Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Customers Street Address to deliver to 
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Customers State to deliver to 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Customers City to deliver to 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Customers Zipcode to deliver to
        /// Must be 5 numbers long
        /// </summary>
        public string ZipCode  { get; set; }

        /// <summary>
        /// Customers valid Email Address
        /// Must be 50 characters or less
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Customers valid Password
        /// Must be 8-50 characters long
        /// </summary>
        public string Password { get; set; }

    }
}
