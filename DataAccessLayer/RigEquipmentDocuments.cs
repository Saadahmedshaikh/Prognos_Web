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
    
    public partial class RigEquipmentDocuments
    {
        public System.Guid RigEquipmentDocumentID { get; set; }
        public string RigEquipmentDocumentSharepointID { get; set; }
        public System.Guid RigEquipmentID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int DocumentCategory { get; set; }
        public Nullable<bool> IsDeletedFlag { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOnDate { get; set; }
        public Nullable<System.Guid> DocumentId { get; set; }
        public Nullable<System.DateTime> CertDate { get; set; }
        public string CertNo { get; set; }
    
        public virtual RigEquipment RigEquipment { get; set; }
    }
}
