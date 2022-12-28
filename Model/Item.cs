using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Model
{
    [PrimaryKey(nameof(CountryCode), nameof(CompanyPrefix), nameof(CheckCode))]
    public class Item
    {
        public int CountryCode { get; set; }
        public int CompanyPrefix { get; set; }
        public int CheckCode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public uint Stock { get; set; }
        public List<Purchase> Sales { get; set; }
        public Item(int CountryCode, int CompanyPrefix, int CheckCode, string Name, float Price)
        {
            this.CountryCode = CountryCode;
            this.CompanyPrefix = CompanyPrefix;
            this.CheckCode = CheckCode;
            this.Name = Name;
            this.Price = Price;
            this.Sales = new List<Purchase>();
        }
    }
}
