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
    
    public partial class LK_BLUE_LINK_PATTERN
    {
        public LK_BLUE_LINK_PATTERN()
        {
            this.LK_BLUE_LINK_RELATION_ENTRY = new HashSet<LK_BLUE_LINK_RELATION_ENTRY>();
            this.LK_BLUE_LINK_SOURCE_ENTRY = new HashSet<LK_BLUE_LINK_SOURCE_ENTRY>();
            this.LK_BLUE_LINK_SOURCE_PUBLISH = new HashSet<LK_BLUE_LINK_SOURCE_PUBLISH>();
            this.LK_BLUE_LINK_SUBSCRIBE = new HashSet<LK_BLUE_LINK_SUBSCRIBE>();
        }
    
        public int SID { get; set; }
        public int LINK_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public Nullable<long> DELETED_TRACKING_ID { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual LK_BLUE_LINK_ITEM LK_BLUE_LINK_ITEM { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
        public virtual ICollection<LK_BLUE_LINK_RELATION_ENTRY> LK_BLUE_LINK_RELATION_ENTRY { get; set; }
        public virtual ICollection<LK_BLUE_LINK_SOURCE_ENTRY> LK_BLUE_LINK_SOURCE_ENTRY { get; set; }
        public virtual ICollection<LK_BLUE_LINK_SOURCE_PUBLISH> LK_BLUE_LINK_SOURCE_PUBLISH { get; set; }
        public virtual ICollection<LK_BLUE_LINK_SUBSCRIBE> LK_BLUE_LINK_SUBSCRIBE { get; set; }
    }
}
