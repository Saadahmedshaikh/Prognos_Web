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
    
    public partial class QualityReport_WorkloadStatus_Main_Result
    {
        public string Rigname { get; set; }
        public Nullable<int> MonthlyCompletedJobs { get; set; }
        public Nullable<int> MonthlyOverdueJobs { get; set; }
        public Nullable<decimal> MonthlyEfficiency { get; set; }
        public Nullable<int> MonthlyReviewOverdueJobs { get; set; }
        public Nullable<int> InspectionOverdueJobs { get; set; }
        public Nullable<int> MonthlyReports { get; set; }
        public decimal Code8MonthHours { get; set; }
        public Nullable<int> Overdue_ICRs { get; set; }
        public Nullable<int> ICRs { get; set; }
        public Nullable<int> AutoGeneratedICRs { get; set; }
        public Nullable<System.DateTime> dtReportFrom { get; set; }
        public Nullable<System.DateTime> dtReportTo { get; set; }
        public string Country { get; set; }
    }
}