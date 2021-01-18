using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDb.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public IList<Product> Products { get; set; }











    }
}
