﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Desctop.Models
{
    public partial class Order_status
    {
        public Order_status()
        {
            Order = new HashSet<Order>();
        }

        public int Id_order_status { get; set; }
        public string title { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}