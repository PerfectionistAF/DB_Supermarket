using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Model
{
    [PrimaryKey(nameof(MobilePhone), nameof(TaxRegNo), nameof(CountryCode), nameof(CompanyPrefix), nameof(CheckCode))]
    public class Purchase
    {
        public string MobilePhone { get; set; }
        public Customer Customer { get; set; }
        public int TaxRegNo { get; set; }
        public Shop Shop {get; set; }
        public int CountryCode { get; set; }
        public int CompanyPrefix { get; set; }
        public int CheckCode { get; set; }
        public Item Item {get; set; }
        public uint Quantity { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}
