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
    
    public partial class FormInfo
    {
        public FormInfo()
        {
            this.WorkFlowRun = new HashSet<WorkFlowRun>();
        }
    
        public System.Guid FormID { get; set; }
        public string FormName { get; set; }
        public bool IsEnable { get; set; }
        public int CategoryID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAnnex { get; set; }
    
        public virtual FormCategory FormCategory { get; set; }
        public virtual ICollection<WorkFlowRun> WorkFlowRun { get; set; }
    }
}
