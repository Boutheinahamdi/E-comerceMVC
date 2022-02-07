using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Models
{
    public class LignePanier
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int Quantité { get; set; }
        public Product product { get; set; }
        public int PanierId { get; set; }
        public float Montant() { return Quantité * product.Price; }
    }
}
