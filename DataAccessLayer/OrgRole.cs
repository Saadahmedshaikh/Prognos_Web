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
    
    public partial class OrgRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgRole()
        {
            this.DailyActivityReport = new HashSet<DailyActivityReport>();
            this.PMServiceFormDefinition = new HashSet<PMServiceFormDefinition>();
            this.RigEquipmentScheduleJobs = new HashSet<RigEquipmentScheduleJobs>();
            this.OrgUserRole = new HashSet<OrgUserRole>();
        }
    
        public System.Guid RoleID { get; set; }
        public Nullable<System.Guid> ParentRole { get; set; }
        public string RoleNamePrm { get; set; }
        public string RoleNameSec { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyActivityReport> DailyActivityReport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMServiceFormDefinition> PMServiceFormDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentScheduleJobs> RigEquipmentScheduleJobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgUserRole> OrgUserRole { get; set; }
    }
}
