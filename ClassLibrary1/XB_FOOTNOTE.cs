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
    
    public partial class XB_FOOTNOTE
    {
        public XB_FOOTNOTE()
        {
            this.XB_FOOTNOTE_STR_ITEM = new HashSet<XB_FOOTNOTE_STR_ITEM>();
        }
    
        public int SID { get; set; }
        public int DOC_SID { get; set; }
        public string LANG { get; set; }
        public string LABEL { get; set; }
    
        public virtual OM_DOCUMENT_INFO OM_DOCUMENT_INFO { get; set; }
        public virtual ICollection<XB_FOOTNOTE_STR_ITEM> XB_FOOTNOTE_STR_ITEM { get; set; }
    }
}
