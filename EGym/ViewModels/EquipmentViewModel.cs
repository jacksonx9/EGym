using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EGym.Models;

namespace EGym.ViewModels
{
    public class EquipmentViewModel
    {
        public Equipment Equipment { get; set; }
        public List<Customer> Customers { get; set; }
    }
}