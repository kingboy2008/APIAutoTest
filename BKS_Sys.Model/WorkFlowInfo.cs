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
    
    public partial class WorkFlowInfo
    {
        public WorkFlowInfo()
        {
            this.WorkFlowProcess = new HashSet<WorkFlowProcess>();
            this.WorkFlowRun = new HashSet<WorkFlowRun>();
            this.WorkFlowRunProc = new HashSet<WorkFlowRunProc>();
        }
    
        public System.Guid FlowID { get; set; }
        public string FlowName { get; set; }
        public System.Guid FormID { get; set; }
        public string FlowDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int CheckMode { get; set; }
        public bool IsSendMsg { get; set; }
        public bool IsDelete { get; set; }
        public bool IsPrintCheck { get; set; }
    
        public virtual ICollection<WorkFlowProcess> WorkFlowProcess { get; set; }
        public virtual ICollection<WorkFlowRun> WorkFlowRun { get; set; }
        public virtual ICollection<WorkFlowRunProc> WorkFlowRunProc { get; set; }
    }
}
