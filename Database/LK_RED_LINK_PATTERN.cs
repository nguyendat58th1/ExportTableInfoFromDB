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
    
    public partial class LK_RED_LINK_PATTERN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LK_RED_LINK_PATTERN()
        {
            this.LK_RED_LINK_PERIOD = new HashSet<LK_RED_LINK_PERIOD>();
            this.LK_RED_LINK_RELATION_ENTRY = new HashSet<LK_RED_LINK_RELATION_ENTRY>();
            this.LK_RED_LINK_SUBSCRIBE = new HashSet<LK_RED_LINK_SUBSCRIBE>();
        }
    
        public int SID { get; set; }
        public int BRANCH_SID { get; set; }
        public string PATTERN_NAME { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public bool INVALID_FLAG { get; set; }
    
        public virtual LK_RED_LINK_BRANCH LK_RED_LINK_BRANCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_RED_LINK_PERIOD> LK_RED_LINK_PERIOD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_RED_LINK_RELATION_ENTRY> LK_RED_LINK_RELATION_ENTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LK_RED_LINK_SUBSCRIBE> LK_RED_LINK_SUBSCRIBE { get; set; }
    }
}
