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
    
    public partial class usp_Helper_ListAllSchedules_Result
    {
        public string OrgNamePrm { get; set; }
        public string EquipmentName { get; set; }
        public string FamilyName { get; set; }
        public string RigEquipmentName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Nullable<int> UniqueId { get; set; }
        public string ScheduleBasis { get; set; }
        public string ScheduleType { get; set; }
        public Nullable<int> RecurranceCalendarValue { get; set; }
        public Nullable<int> CalendarAlertMargin { get; set; }
        public Nullable<int> CalendarEscalationMargin { get; set; }
        public Nullable<int> MeterAlertMargin { get; set; }
        public Nullable<int> MeterEscalationMargin { get; set; }
        public Nullable<bool> IsScheduleSuspended { get; set; }
        public string FormName { get; set; }
        public string RoleNamePrm { get; set; }
    }
}