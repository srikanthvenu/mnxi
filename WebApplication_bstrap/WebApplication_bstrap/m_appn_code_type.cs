//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication_bstrap
{
    using System;
    using System.Collections.Generic;
    
    public partial class m_appn_code_type
    {
        public m_appn_code_type()
        {
            this.d_appn_code = new HashSet<d_appn_code>();
        }
    
        public int appn_code_type_id { get; set; }
        public string appn_code_type_desc { get; set; }
        public Nullable<int> createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public Nullable<int> modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
    
        public virtual ICollection<d_appn_code> d_appn_code { get; set; }
    }
}
