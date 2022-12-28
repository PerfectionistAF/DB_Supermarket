using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Model
{
    public class Customer
    {
        [Key]
        public string MobilePhone { get; set; }
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public string City {get; set; }
        public string Street {get; set; }
        public List<Purchase> purchases { get; set; }
        public Customer(string FirstName, string LastName, string MobilePhone, string City, string Street)
        {
            this.MobilePhone = MobilePhone;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
            this.Street = Street;
            this.purchases = new List<Purchase>();
        }
    }
}
