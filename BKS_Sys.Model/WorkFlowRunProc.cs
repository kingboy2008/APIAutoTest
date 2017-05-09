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
    
    public partial class WorkFlowRunProc
    {
        public System.Guid RunProcID { get; set; }
        public System.Guid RunID { get; set; }
        public System.Guid ProcID { get; set; }
        public int SortCode { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public string ProcMessage { get; set; }
        public Nullable<int> ProcStatus { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> IsSigned { get; set; }
        public Nullable<System.Guid> UserIDSigned { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserInfo UserInfo1 { get; set; }
        public virtual WorkFlowInfo WorkFlowInfo { get; set; }
        public virtual WorkFlowRun WorkFlowRun { get; set; }
    }
}