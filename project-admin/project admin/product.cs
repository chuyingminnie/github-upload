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
    
    public partial class product
    {
        public product()
        {
            this.orderproducts = new HashSet<orderproduct>();
            this.showcase_product = new HashSet<showcase_product>();
        }
    
        public int productID { get; set; }
        public string productName { get; set; }
        public int unitPrice { get; set; }
        public string remark { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<orderproduct> orderproducts { get; set; }
        public virtual ICollection<showcase_product> showcase_product { get; set; }
    }
}
