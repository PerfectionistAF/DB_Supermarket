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
        public int MobilePhone { get; set; }
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public string City {get; set; }
        public string Street {get; set; }
        public List<Purchase> purchases { get; set; }
    }
}
