//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MorningReportOperations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MorningReportOperations()
        {
            this.RigRepairAlerts = new HashSet<RigRepairAlerts>();
        }
    
        public System.Guid OperationsID { get; set; }
        public System.Guid MorningReportID { get; set; }
        public string OperationFrom { get; set; }
        public string OperationTo { get; set; }
        public Nullable<decimal> OperationHours { get; set; }
        public string OperationDetails { get; set; }
        public Nullable<bool> Is6HrOperation { get; set; }
        public System.Guid IACDCodeID { get; set; }
        public Nullable<System.Guid> RigEquipmentID { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string NPT { get; set; }
        public string Fault { get; set; }
        public Nullable<decimal> Depth { get; set; }
    
        public virtual IACDCodes IACDCodes { get; set; }
        public virtual MorningReport MorningReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigRepairAlerts> RigRepairAlerts { get; set; }
        public virtual RigEquipment RigEquipment { get; set; }
    }
}