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
    
    public partial class ID_INDESIGN_FILE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ID_INDESIGN_FILE()
        {
            this.ID_INDESIGN_PDF_DATA = new HashSet<ID_INDESIGN_PDF_DATA>();
            this.ID_INDESIGN_FILE_DATA = new HashSet<ID_INDESIGN_FILE_DATA>();
            this.ID_INDESIGN_IMG = new HashSet<ID_INDESIGN_IMG>();
            this.ID_PAGE_INFO = new HashSet<ID_PAGE_INFO>();
            this.ID_PARTS_IMAGE_SETTING = new HashSet<ID_PARTS_IMAGE_SETTING>();
        }
    
        public int SID { get; set; }
        public string INDESIGN_FILE_NAME { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public System.DateTime DATA_UPDATE_DATE { get; set; }
        public int ORDER_SID { get; set; }
        public bool DOWNLOAD_FLAG { get; set; }
        public bool LABEL_COMPARECHECK_RESULT_FLAG { get; set; }
        public string INDD_APP_VER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ID_INDESIGN_PDF_DATA> ID_INDESIGN_PDF_DATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ID_INDESIGN_FILE_DATA> ID_INDESIGN_FILE_DATA { get; set; }
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ID_INDESIGN_IMG> ID_INDESIGN_IMG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ID_PAGE_INFO> ID_PAGE_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ID_PARTS_IMAGE_SETTING> ID_PARTS_IMAGE_SETTING { get; set; }
    }
}
