using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public string Informations { get; set; }
        public Catgorie catgorie { get; set; }
    }
}
