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
    
    public partial class Dispatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dispatch()
        {
            this.Client_Purchase_Order = new HashSet<Client_Purchase_Order>();
        }
    
        public int Dispatch_Id { get; set; }
        public Nullable<System.DateTime> Dispatch_Date { get; set; }
        public string Collector_Name { get; set; }
        public Nullable<System.TimeSpan> Dispatch_Time { get; set; }
        public string Proof_Of_Dispatch { get; set; }
        public Nullable<int> Vehicle_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public string DP_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_Purchase_Order> Client_Purchase_Order { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
