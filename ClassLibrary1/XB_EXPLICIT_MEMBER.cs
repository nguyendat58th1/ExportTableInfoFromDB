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
    
    public partial class XB_EXPLICIT_MEMBER
    {
        public XB_EXPLICIT_MEMBER()
        {
            this.XB_STR_ITEM_EXPLICIT_MEMBER = new HashSet<XB_STR_ITEM_EXPLICIT_MEMBER>();
        }
    
        public int SID { get; set; }
        public int BASIC_SID { get; set; }
        public string DIMENTION { get; set; }
        public string MEMBER { get; set; }
    
        public virtual XB_BASIC_INFO XB_BASIC_INFO { get; set; }
        public virtual ICollection<XB_STR_ITEM_EXPLICIT_MEMBER> XB_STR_ITEM_EXPLICIT_MEMBER { get; set; }
    }
}
