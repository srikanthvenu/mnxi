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
    
    public partial class m_dona_return_refund_History
    {
        public int ret_ref_His_Id { get; set; }
        public Nullable<int> sc_tran_id { get; set; }
        public Nullable<int> sc_cart_id { get; set; }
        public Nullable<bool> is_ret_ref { get; set; }
        public Nullable<bool> is_repaid { get; set; }
        public Nullable<System.DateTime> ret_ref_date { get; set; }
        public string ret_ref_reason { get; set; }
        public string ret_ref_mode { get; set; }
        public string ret_ref_chk_number { get; set; }
        public string ret_ref_bank_name { get; set; }
        public Nullable<System.DateTime> ret_ref_check_date { get; set; }
        public string ret_ref_col_by { get; set; }
        public string ret_ref_chk_name { get; set; }
        public Nullable<decimal> return_amt { get; set; }
        public Nullable<decimal> repaid_amt { get; set; }
        public Nullable<decimal> refund_amt { get; set; }
        public Nullable<int> Mode { get; set; }
        public string createdby { get; set; }
        public Nullable<System.DateTime> createdon { get; set; }
        public string modifiedby { get; set; }
        public Nullable<System.DateTime> modifiedon { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> ret_netamt { get; set; }
        public string Active { get; set; }
        public string inve_cate_type { get; set; }
        public string inve_cate { get; set; }
        public string inve_serv { get; set; }
        public Nullable<int> numb_unit { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> chkmode { get; set; }
    }
}
