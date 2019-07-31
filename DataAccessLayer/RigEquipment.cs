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
    
    public partial class RigEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RigEquipment()
        {
            this.ExRegisterDetails = new HashSet<ExRegisterDetails>();
            this.MaterialTransferDetails = new HashSet<MaterialTransferDetails>();
            this.MorningReportOperations = new HashSet<MorningReportOperations>();
            this.PMServiceForms = new HashSet<PMServiceForms>();
            this.PressureVesselRegisterDetails = new HashSet<PressureVesselRegisterDetails>();
            this.ReleifValveRegisterDetails = new HashSet<ReleifValveRegisterDetails>();
            this.RigEquipmentDocuments = new HashSet<RigEquipmentDocuments>();
            this.RigEquipmentOverallHours = new HashSet<RigEquipmentOverallHours>();
            this.RigEquipmentSchedule = new HashSet<RigEquipmentSchedule>();
            this.RigEquipmentSchedule1 = new HashSet<RigEquipmentSchedule>();
            this.RigEquipmentSchedule2 = new HashSet<RigEquipmentSchedule>();
            this.UserMeasurementAlerts = new HashSet<UserMeasurementAlerts>();
            this.RigEquipmentSchedule3 = new HashSet<RigEquipmentSchedule>();
            this.RigEquipmentUnscheduledRepairs = new HashSet<RigEquipmentUnscheduledRepairs>();
            this.RigEquipmentHours = new HashSet<RigEquipmentHours>();
            this.RigEquipmentSpecification = new HashSet<RigEquipmentSpecification>();
            this.RigEquipmentOneTimeJob = new HashSet<RigEquipmentOneTimeJob>();
            this.RigEquipmentTransferDetails = new HashSet<RigEquipmentTransferDetails>();
            this.RigEquipmentInspections = new HashSet<RigEquipmentInspections>();
        }
    
        public System.Guid RigEquipmentID { get; set; }
        public System.Guid OrgUnitID { get; set; }
        public Nullable<System.Guid> EquipmentID { get; set; }
        public Nullable<System.Guid> ParentRigEquipmentID { get; set; }
        public string SerialNo { get; set; }
        public string MaterialNumber { get; set; }
        public string RigEquipmentName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> FunctionStartDate { get; set; }
        public Nullable<System.Guid> EquipmentCriticalityId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte[] UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Nullable<int> UniqueId { get; set; }
        public Nullable<System.Guid> Destination { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> cost { get; set; }
        public Nullable<bool> IsRental { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public string Deletedby { get; set; }
        public Nullable<System.DateTime> LastFieldInspectionDate { get; set; }
        public Nullable<System.DateTime> LastFullInspectionDate { get; set; }
        public Nullable<System.DateTime> COC { get; set; }
        public Nullable<System.DateTime> CALIBRION { get; set; }
        public Nullable<System.DateTime> INSPECT { get; set; }
        public Nullable<System.DateTime> PRESSURE { get; set; }
        public Nullable<System.DateTime> LOADTEST { get; set; }
        public Nullable<System.DateTime> CATIII { get; set; }
        public Nullable<System.DateTime> CATIV { get; set; }
        public string Comments { get; set; }
        public string COCText { get; set; }
        public string CALIBRIONText { get; set; }
        public string INSPECTText { get; set; }
        public string PRESSUREText { get; set; }
        public string LOADTESTText { get; set; }
        public string CATIIIText { get; set; }
        public string CATIVText { get; set; }
        public Nullable<System.Guid> CurrentEquipmentID { get; set; }
        public string RFID { get; set; }
        public bool IsSpare { get; set; }
        public Nullable<bool> IsGroupAsset { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentCriticality EquipmentCriticality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExRegisterDetails> ExRegisterDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialTransferDetails> MaterialTransferDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MorningReportOperations> MorningReportOperations { get; set; }
        public virtual OrgUnit OrgUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMServiceForms> PMServiceForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PressureVesselRegisterDetails> PressureVesselRegisterDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleifValveRegisterDetails> ReleifValveRegisterDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentDocuments> RigEquipmentDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentOverallHours> RigEquipmentOverallHours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentSchedule> RigEquipmentSchedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentSchedule> RigEquipmentSchedule1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentSchedule> RigEquipmentSchedule2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMeasurementAlerts> UserMeasurementAlerts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentSchedule> RigEquipmentSchedule3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentUnscheduledRepairs> RigEquipmentUnscheduledRepairs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentHours> RigEquipmentHours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentSpecification> RigEquipmentSpecification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentOneTimeJob> RigEquipmentOneTimeJob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentTransferDetails> RigEquipmentTransferDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RigEquipmentInspections> RigEquipmentInspections { get; set; }
    }
}