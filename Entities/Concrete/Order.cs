using Core.Abstrac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order :IEntity
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
