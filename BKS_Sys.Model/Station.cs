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
    
    public partial class Station
    {
        public System.Guid StationID { get; set; }
        public string StationName { get; set; }
        public Nullable<int> Province { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> County { get; set; }
        public string DetailAddress { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsDelete { get; set; }
    }
}
