//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKS_Sys.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocusDetail
    {
        public System.Guid DetailID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public string Token { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<System.DateTime> LocusDate { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public Nullable<int> LocationMethod { get; set; }
        public Nullable<int> LocationSource { get; set; }
        public Nullable<int> StayMin { get; set; }
        public Nullable<int> Interval { get; set; }
        public string LocationJson { get; set; }
        public int IsDisplay { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
