﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Desctop.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Supply = new HashSet<Supply>();
        }

        public int Id_suppliers { get; set; }
        public int Id_cities { get; set; }
        public string title { get; set; }
        public string phone_namber { get; set; }

        public virtual Citi Id_citiesNavigation { get; set; }
        public virtual ICollection<Supply> Supply { get; set; }
    }
}