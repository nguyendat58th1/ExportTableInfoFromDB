//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class OM_FONT_INFO_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OM_FONT_INFO_MASTER()
        {
            this.DC_FONT_INFO = new HashSet<DC_FONT_INFO>();
            this.DC_PRINT_INFO_HEAD = new HashSet<DC_PRINT_INFO_HEAD>();
            this.DC_PRINT_INFO_HEAD1 = new HashSet<DC_PRINT_INFO_HEAD>();
            this.DC_PRINT_INFO_INDEX_SETTING = new HashSet<DC_PRINT_INFO_INDEX_SETTING>();
        }
    
        public int SID { get; set; }
        public string FONT_NAME { get; set; }
        public string FONT_FAMILY_NAME { get; set; }
        public string FALLBACK_FONT_FAMILY_NAME { get; set; }
        public bool FONT_TYPE { get; set; }
        public short DISPLAY_ORDER { get; set; }
        public bool AVALABLE { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_FONT_INFO> DC_FONT_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_PRINT_INFO_HEAD> DC_PRINT_INFO_HEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_PRINT_INFO_HEAD> DC_PRINT_INFO_HEAD1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_PRINT_INFO_INDEX_SETTING> DC_PRINT_INFO_INDEX_SETTING { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
