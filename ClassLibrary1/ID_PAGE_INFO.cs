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
    
    public partial class ID_PAGE_INFO
    {
        public ID_PAGE_INFO()
        {
            this.ID_LABEL_PAGE = new HashSet<ID_LABEL_PAGE>();
        }
    
        public int SID { get; set; }
        public int INDESIGN_SID { get; set; }
        public string PAGE_NAME { get; set; }
        public short PAGE_NUM { get; set; }
        public short LINK_PAGE_COUNT { get; set; }
    
        public virtual ID_INDESIGN_FILE ID_INDESIGN_FILE { get; set; }
        public virtual ICollection<ID_LABEL_PAGE> ID_LABEL_PAGE { get; set; }
    }
}
