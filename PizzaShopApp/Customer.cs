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

        [StringLength(5)]
        public string ZipCode  { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
