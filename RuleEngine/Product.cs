using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngine
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }
        public string Base { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    } 
}
