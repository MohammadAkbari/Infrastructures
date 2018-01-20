using System;
using System.Collections.Generic;

namespace SqlServer.Models
{
    public partial class ClinicDrug
    {
        public int ClinicDrugId { get; set; }
        public string BrandName { get; set; }
        public string DosageForms { get; set; }
        public string EnglishName { get; set; }
        public string Interactions { get; set; }
        public string MechanismOfAction { get; set; }
        public string PersianName { get; set; }
        public string Precautions { get; set; }
        public string SideEffects { get; set; }
        public string Indications { get; set; }
        public bool Deleted { get; set; }
    }
}
