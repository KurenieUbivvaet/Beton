﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Desctop.Models
{
    public partial class Order
    {
        public int Id_order { get; set; }
        public int Id_users { get; set; }
        public int Id_stoks { get; set; }
        public int Id_goods { get; set; }
        public int Number_of_centners { get; set; }
        public int Id_payment_method { get; set; }
        public int Id_order_status { get; set; }
        public int Id_discounts { get; set; }
        public decimal total_coast { get; set; }

        public virtual Discount Id_discountsNavigation { get; set; }
        public virtual Good Id_goodsNavigation { get; set; }
        public virtual Order_status Id_order_statusNavigation { get; set; }
        public virtual Payment_method Id_payment_methodNavigation { get; set; }
        public virtual Stock Id_stoksNavigation { get; set; }
        public virtual User Id_usersNavigation { get; set; }
    }
}