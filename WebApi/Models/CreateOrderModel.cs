using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CreateOrderModel
    {
        public bool Status { get; set; }
        public int UserId { get; set; }
    }
}
