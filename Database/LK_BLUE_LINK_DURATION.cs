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
    
    public partial class LK_BLUE_LINK_DURATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LK_BLUE_LINK_DURATION()
        {
            this.LK_BLUE_LINK_DURATION_ENTRY = new HashSet<LK_BLUE_LINK_DURATION_ENTRY>();
            this.LK_BLUE_LINK_DURATION_PUBLISH = new HashSet<LK_BLUE_LINK_DURATION_PUBLISH>();
            this.LK_BLUE_LINK_SOURCE_ENTRY = new HashSet<LK_BLUE_LINK_SOURCE_ENTRY>();
            this.LK_BLUE_LINK_SUBSCRIBE = new HashSet<LK_BLUE_LINK_SUBSCRIBE>();
        }
    
        public int SID { get; set; }
        public int COMPANY_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public Nullable<long> DELETED_TRACKING_ID { get; set; }
    
        public virtual OM_COMPANY_INFO OM_COMPANY_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_BLUE_LINK_DURATION_ENTRY> LK_BLUE_LINK_DURATION_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_BLUE_LINK_DURATION_PUBLISH> LK_BLUE_LINK_DURATION_PUBLISH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_BLUE_LINK_SOURCE_ENTRY> LK_BLUE_LINK_SOURCE_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_BLUE_LINK_SUBSCRIBE> LK_BLUE_LINK_SUBSCRIBE { get; set; }
    }
}
