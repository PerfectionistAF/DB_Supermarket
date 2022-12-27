using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Model
{
    [PrimaryKey(nameof(TaxRegNo), nameof(CountryCode), nameof(CompanyPrefix), nameof(CheckCode))]
    public class Provide
    {
        public int TaxRegNo { get; set; }
        public Shop Shop { get; set; }
        public int CountryCode { get; set; }
        public int CompanyPrefix { get; set; }
        public int CheckCode { get; set; }
        public Item Item { get; set; }
        public uint Quota { get; set; }
    }
}
