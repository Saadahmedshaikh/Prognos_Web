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
    
    public partial class PMServiceFormSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMServiceFormSection()
        {
            this.PMServiceFormSectionProcedures = new HashSet<PMServiceFormSectionProcedures>();
            this.PMServiceFormSectionDiagrams = new HashSet<PMServiceFormSectionDiagrams>();
        }
    
        public System.Guid PMServiceFormSectionID { get; set; }
        public System.Guid PMServiceFormDefinitionID { get; set; }
        public string SectionName { get; set; }
        public string Label { get; set; }
        public Nullable<int> SequenceNumber { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual PMServiceFormDefinition PMServiceFormDefinition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMServiceFormSectionProcedures> PMServiceFormSectionProcedures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMServiceFormSectionDiagrams> PMServiceFormSectionDiagrams { get; set; }
    }
}