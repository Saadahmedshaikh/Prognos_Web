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
    
    public partial class ATRReviewedRequest
    {
        public long ReviewedRequestID { get; set; }
        public Nullable<long> ATRequestID { get; set; }
        public string ReviewedBy { get; set; }
        public System.Guid SenderOrgRoleID { get; set; }
        public int SenderLevel { get; set; }
        public Nullable<bool> IsReviewed { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
