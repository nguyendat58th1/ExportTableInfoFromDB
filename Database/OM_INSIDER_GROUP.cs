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
    
    public partial class OM_INSIDER_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OM_INSIDER_GROUP()
        {
            this.OM_INSIDER_GROUP_DOC_FORM_MAP = new HashSet<OM_INSIDER_GROUP_DOC_FORM_MAP>();
            this.OM_ROLE_INFO = new HashSet<OM_ROLE_INFO>();
        }
    
        public int SID { get; set; }
        public string INSIDER_GROUP_NAME { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OM_INSIDER_GROUP_DOC_FORM_MAP> OM_INSIDER_GROUP_DOC_FORM_MAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OM_ROLE_INFO> OM_ROLE_INFO { get; set; }
    }
}
