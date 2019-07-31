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
    
    public partial class SecPermission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecPermission()
        {
            this.SecActivityLogDetail = new HashSet<SecActivityLogDetail>();
            this.SecUserGroupPermission = new HashSet<SecUserGroupPermission>();
        }
    
        public string PermissionID { get; set; }
        public System.Guid AppID { get; set; }
        public string ParentPermissionID { get; set; }
        public string PermissionNamePrm { get; set; }
        public string PermissionNameSec { get; set; }
        public string PermissionType { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> SortOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecActivityLogDetail> SecActivityLogDetail { get; set; }
        public virtual SecApplication SecApplication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecUserGroupPermission> SecUserGroupPermission { get; set; }
    }
}
