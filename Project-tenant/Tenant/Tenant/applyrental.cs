//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tenant
{
    using System;
    using System.Collections.Generic;
    
    public partial class applyrental
    {
        public int applyRentalID { get; set; }
        public System.DateTime applyDate { get; set; }
        public int showcaseID { get; set; }
        public int tenantID { get; set; }
        public System.DateTime rentStartDate { get; set; }
        public int month { get; set; }
        public string approve { get; set; }
    
        public virtual tenant tenant { get; set; }
        public virtual showcase showcase { get; set; }
    }
}
