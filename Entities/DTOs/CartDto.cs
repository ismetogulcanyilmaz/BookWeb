using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CartDto :IDto
    {
        public int CartId { get; set; }
        public int BookId { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public decimal BookUnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public string Photo { get; set; }
    }
}
