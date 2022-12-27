using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Model
{
    public class Shop
    {
        [Key]
        public int TaxRegNo { get; set; }
        public string Name {get; set; }
        public string ProductSector {get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<Purchase> Sales { get; set; }
    }
}
