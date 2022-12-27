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
        public Shop Shop { get; set; }
        public List<Purchase> Sales { get; set; }
    }
}
