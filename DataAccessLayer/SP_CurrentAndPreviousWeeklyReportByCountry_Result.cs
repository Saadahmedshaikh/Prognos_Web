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
    
    public partial class SP_CurrentAndPreviousWeeklyReportByCountry_Result
    {
        public System.Guid OrgUnitID { get; set; }
        public string RigName { get; set; }
        public Nullable<int> CurrentWeekCompletedJobs { get; set; }
        public Nullable<int> PreviousWeekCompletedJobs { get; set; }
        public Nullable<int> CurrentWeekdueJobs { get; set; }
        public Nullable<int> PreviousWeekdueJobs { get; set; }
        public Nullable<int> CurrentWeekOverdueJobs { get; set; }
        public Nullable<int> PreviousWeekOverdueJobs { get; set; }
        public Nullable<int> CurrentWeekInspectionOverdue { get; set; }
        public Nullable<int> PreviousWeekInspectionOverdue { get; set; }
        public Nullable<int> CurrentWeekReviewOverdue { get; set; }
        public Nullable<int> PreviousWeekReviewOverdue { get; set; }
        public System.DateTime createdOn { get; set; }
        public Nullable<int> CurrentWeekMoringReports { get; set; }
        public Nullable<int> PreviousWeekMoringReports { get; set; }
        public Nullable<int> Current_Week_TOTAL_ICRs { get; set; }
        public Nullable<int> Previous_Week_TOTAL_ICRs { get; set; }
        public Nullable<int> CurrentWeekICRs { get; set; }
        public Nullable<int> PreviousWeekICRs { get; set; }
        public Nullable<int> CurrentWeekOverDueICRs { get; set; }
        public Nullable<int> PreviousWeekOverdueICRs { get; set; }
        public Nullable<int> CurrentWeekAutoGeneratedICRs { get; set; }
        public Nullable<int> PreviousWeekAutoGeneratedICRs { get; set; }
        public string Column1 { get; set; }
        public string Country { get; set; }
    }
}
