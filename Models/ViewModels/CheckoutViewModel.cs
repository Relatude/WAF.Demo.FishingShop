using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.Native;
using WAF.Engine.Content.RelatudeFishingShop;

namespace RelatudeFishingShop.Models.ViewModels
{
    public class CheckoutViewModel
    {
        public Article Page { get; set; }
        public Order Order { get; set; }
        public List<Tuple<int, string, double, bool>> ShippingMethods { get; set; }
        public List<Tuple<int, string, bool>> PaymentMethods { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Comment { get; set; }
        public int Shipping { get; set; }
        public int Payment { get; set; }
    }
}