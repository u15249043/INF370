//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frmAddEmployeeType
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Unit_Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_Unit_Price()
        {
            this.Client_Purchase_Order_Line = new HashSet<Client_Purchase_Order_Line>();
        }
    
        public int Order_Price_ID { get; set; }
        public Nullable<decimal> Order_Price { get; set; }
        public Nullable<System.DateTime> Order_Price_Year { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public string OP_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_Purchase_Order_Line> Client_Purchase_Order_Line { get; set; }
        public virtual Product Product { get; set; }
    }
}