//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class OM_ATTACH_DOC_SHINKYUU_INFO
    {
        public OM_ATTACH_DOC_SHINKYUU_INFO()
        {
            this.OM_ATTACH_DOC_SHINKYUU_DATA = new HashSet<OM_ATTACH_DOC_SHINKYUU_DATA>();
        }
    
        public int SID { get; set; }
        public int FUND_SID { get; set; }
        public Nullable<System.DateTime> APPLICATION_DATE { get; set; }
        public short DISPLAY_ORDER { get; set; }
        public string FILE_NAME { get; set; }
        public System.DateTime UPLOAD_DATE { get; set; }
        public int UPLOAD_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual ICollection<OM_ATTACH_DOC_SHINKYUU_DATA> OM_ATTACH_DOC_SHINKYUU_DATA { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_FUND_INFO OM_FUND_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
