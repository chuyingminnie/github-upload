//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class staff_attendance
    {
        public int staff_attendance_ID { get; set; }
        public int staffID { get; set; }
        public System.DateTime date { get; set; }
        public System.TimeSpan basicPunchIn { get; set; }
        public System.TimeSpan basicPunchOut { get; set; }
        public Nullable<System.TimeSpan> punchIn { get; set; }
        public Nullable<System.TimeSpan> punchOut { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
