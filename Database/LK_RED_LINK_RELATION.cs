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
    
    public partial class LK_RED_LINK_RELATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LK_RED_LINK_RELATION()
        {
            this.LK_RED_LINK_RELATION_ENTRY = new HashSet<LK_RED_LINK_RELATION_ENTRY>();
        }
    
        public int SID { get; set; }
        public int ORDER_GROUP_SID { get; set; }
        public int TARGET_SID { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_RED_LINK_RELATION_ENTRY> LK_RED_LINK_RELATION_ENTRY { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_ORDER_GROUP OM_ORDER_GROUP { get; set; }
        public virtual LK_RED_LINK_TARGET_INDEX LK_RED_LINK_TARGET_INDEX { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
