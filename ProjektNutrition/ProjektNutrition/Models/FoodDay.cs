//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektNutrition.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodDay()
        {
            this.Product_FoodDay = new HashSet<Product_FoodDay>();
        }
    
        public int id { get; set; }
        public string Users_id { get; set; }
        public System.DateTime date { get; set; }
        public double sumCaloric { get; set; }
        public double sumProtein { get; set; }
        public double sumCarb { get; set; }
        public double sumFat { get; set; }
        public string description { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_FoodDay> Product_FoodDay { get; set; }
    }
}
