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
    
    public partial class OM_ATTACH_DOC_FILE_INFO
    {
        public OM_ATTACH_DOC_FILE_INFO()
        {
            this.OM_ATTACH_DOC_FILE_DATA = new HashSet<OM_ATTACH_DOC_FILE_DATA>();
        }
    
        public int SID { get; set; }
        public int ATTACH_DOC_REVISION_SID { get; set; }
        public short ATTACH_DOC_TYPE { get; set; }
        public short FILE_TYPE { get; set; }
        public short FILE_USED_TYPE { get; set; }
        public short DISPLAY_ORDER { get; set; }
        public string FILE_NAME { get; set; }
        public System.DateTime UPLOAD_DATE { get; set; }
        public int UPLOAD_USER_SID { get; set; }
        public System.DateTime FILE_UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual ICollection<OM_ATTACH_DOC_FILE_DATA> OM_ATTACH_DOC_FILE_DATA { get; set; }
        public virtual OM_ATTACH_DOC_REVISION_INFO OM_ATTACH_DOC_REVISION_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
