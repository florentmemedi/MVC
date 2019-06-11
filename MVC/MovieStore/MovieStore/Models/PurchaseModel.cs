using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class PurchaseModel
    {
        public int Id { get; set; }

        public string PurchaseName { get; set; }
        [Required]
        public string Movie { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string User { get; set; }
    }
}
