﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Desctop.Models
{
    public partial class Payment_method
    {
        public Payment_method()
        {
            Order = new HashSet<Order>();
        }

        public int Id_Payment_method { get; set; }
        public string title { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}