using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.DAL.Repositories
{
    public class Product : IDdObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string About { get; set; }
        public int Price { get; set; }
        public int IsAvailable { get; set; }
    }
}
