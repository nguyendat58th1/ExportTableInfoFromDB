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
    
    public partial class ID_INDESIGN_IMG
    {
        public ID_INDESIGN_IMG()
        {
            this.ID_GRAPH_INFO = new HashSet<ID_GRAPH_INFO>();
            this.ID_INDESIGN_IMG_DATA = new HashSet<ID_INDESIGN_IMG_DATA>();
        }
    
        public int SID { get; set; }
        public string IMG_FILE_NAME { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public int IMG_SIZE { get; set; }
        public int INDESIGN_SID { get; set; }
        public short IMG_EDIT_FLAG { get; set; }
        public int DOC_SID { get; set; }
    
        public virtual ICollection<ID_GRAPH_INFO> ID_GRAPH_INFO { get; set; }
        public virtual ID_INDESIGN_FILE ID_INDESIGN_FILE { get; set; }
        public virtual ICollection<ID_INDESIGN_IMG_DATA> ID_INDESIGN_IMG_DATA { get; set; }
        public virtual OM_DOCUMENT_INFO OM_DOCUMENT_INFO { get; set; }
    }
}
