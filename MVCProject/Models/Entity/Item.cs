//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int ItemID { get; set; }

        //[Required(ErrorMessage = "Please fill out this field.")]
        //[MaxLength(50)]
        public string ItemName { get; set; }

        //[Required(ErrorMessage = "Please fill out this field.")]
        //[MaxLength(50)]
        public string Brand { get; set; }
        public Nullable<short> ItemCategory { get; set; }

        //[Required(ErrorMessage = "Please fill out this field.")]
        public Nullable<decimal> ItemCost { get; set; }

        //[Required(ErrorMessage = "Please fill out this field.")]
        public Nullable<byte> Stock { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
