using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int GoodId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Good Good { get; set; }
        public Order Order { get; set; }
    }
}
