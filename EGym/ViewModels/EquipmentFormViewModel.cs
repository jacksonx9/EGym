using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EGym.Models;

namespace EGym.ViewModels
{
    public class EquipmentFormViewModel
    {
        public Equipment Equipment { get; set; }
        public IEnumerable<RentalType> RentalTypes { get; set; }
        public string Title
        {
            get
            {
                return Equipment.Id != 0 ? "Edit Equipment" : "New Equipment";
            }
        }
    }
}