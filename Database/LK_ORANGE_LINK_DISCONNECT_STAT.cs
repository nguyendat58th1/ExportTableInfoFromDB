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
    
    public partial class LK_ORANGE_LINK_DISCONNECT_STAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LK_ORANGE_LINK_DISCONNECT_STAT()
        {
            this.LK_ORANGE_LINK_SUBSCRIBE = new HashSet<LK_ORANGE_LINK_SUBSCRIBE>();
        }
    
        public int SID { get; set; }
        public int GROUP_SID { get; set; }
        public int LINK_SID { get; set; }
        public bool DISCONNECT_STATUS { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        public virtual OM_ORDER_GROUP OM_ORDER_GROUP { get; set; }
        public virtual LK_ORANGE_LINK_ITEM LK_ORANGE_LINK_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_ORANGE_LINK_SUBSCRIBE> LK_ORANGE_LINK_SUBSCRIBE { get; set; }
    }
}
