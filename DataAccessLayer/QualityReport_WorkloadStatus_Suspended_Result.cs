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
    
    public partial class QualityReport_WorkloadStatus_Suspended_Result
    {
        public System.Guid OrgUnitID { get; set; }
        public string RigName { get; set; }
        public Nullable<int> TotalJobs { get; set; }
        public Nullable<int> TotalCompletedJobs { get; set; }
        public Nullable<int> TotalOverdueJobs { get; set; }
        public Nullable<int> MonthlyCompletedJobs { get; set; }
        public Nullable<int> MonthlyOverdueJobs { get; set; }
        public Nullable<int> InspectionOverdue { get; set; }
        public Nullable<int> MonthlyReviewOverdue { get; set; }
        public System.DateTime createdOn { get; set; }
        public Nullable<int> MoringReports { get; set; }
        public Nullable<int> ICRs { get; set; }
        public Nullable<System.DateTime> Column1 { get; set; }
        public string Country { get; set; }
    }
}