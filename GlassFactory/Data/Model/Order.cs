﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassFactory.Data.Model;

public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public DateTime OrderDate { get; set; }
    public string Notes { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}