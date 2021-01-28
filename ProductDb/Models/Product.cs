using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDb.Models
{
    public class Product
    {

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Info { get; set; }
        public decimal Price { get; set; }
        

        public int CategoryID { get; set; }
        public Category Category { get; set; }
      



    }
}
