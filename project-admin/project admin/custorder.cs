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
    
    public partial class custorder
    {
        public custorder()
        {
            this.orderproducts = new HashSet<orderproduct>();
        }
    
        public int orderID { get; set; }
        public int custID { get; set; }
        public System.DateTime orderDate { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<orderproduct> orderproducts { get; set; }
    }
}
