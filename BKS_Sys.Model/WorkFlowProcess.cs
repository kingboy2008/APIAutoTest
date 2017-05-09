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
    
    public partial class WorkFlowProcess
    {
        public System.Guid ProcID { get; set; }
        public System.Guid FlowID { get; set; }
        public string ProcName { get; set; }
        public int SortCode { get; set; }
        public int ProcType { get; set; }
        public bool IsCountersign { get; set; }
        public bool IsBack { get; set; }
        public bool IsNoticeNext { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public System.Guid DeptID { get; set; }
        public System.Guid PostID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public string ParentID { get; set; }
        public bool IsProcIn { get; set; }
        public bool IsProcOut { get; set; }
        public string ProcInFormula { get; set; }
        public string ProcOutFormula { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public virtual WorkFlowInfo WorkFlowInfo { get; set; }
    }
}