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
    
    public partial class DC_PRINT_INFO_BG_IMAGE_DATA
    {
        public DC_PRINT_INFO_BG_IMAGE_DATA()
        {
            this.DC_PRINT_INFO_BG_IMAGE_INFO = new HashSet<DC_PRINT_INFO_BG_IMAGE_INFO>();
            this.DC_PRINT_INFO_BG_IMAGE_INFO1 = new HashSet<DC_PRINT_INFO_BG_IMAGE_INFO>();
            this.DC_PRINT_INFO_BG_IMAGE_INFO2 = new HashSet<DC_PRINT_INFO_BG_IMAGE_INFO>();
        }
    
        public int SID { get; set; }
        public byte[] CONTENTS { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual ICollection<DC_PRINT_INFO_BG_IMAGE_INFO> DC_PRINT_INFO_BG_IMAGE_INFO { get; set; }
        public virtual ICollection<DC_PRINT_INFO_BG_IMAGE_INFO> DC_PRINT_INFO_BG_IMAGE_INFO1 { get; set; }
        public virtual ICollection<DC_PRINT_INFO_BG_IMAGE_INFO> DC_PRINT_INFO_BG_IMAGE_INFO2 { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
