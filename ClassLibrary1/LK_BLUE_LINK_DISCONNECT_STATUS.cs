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
    
    public partial class LK_BLUE_LINK_DISCONNECT_STATUS
    {
        public LK_BLUE_LINK_DISCONNECT_STATUS()
        {
            this.LK_BLUE_LINK_SUBSCRIBE = new HashSet<LK_BLUE_LINK_SUBSCRIBE>();
        }
    
        public int SID { get; set; }
        public int GROUP_SID { get; set; }
        public int LINK_SID { get; set; }
        public short DISCONNECT_STATUS { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        public virtual OM_ORDER_GROUP OM_ORDER_GROUP { get; set; }
        public virtual LK_BLUE_LINK_ITEM LK_BLUE_LINK_ITEM { get; set; }
        public virtual ICollection<LK_BLUE_LINK_SUBSCRIBE> LK_BLUE_LINK_SUBSCRIBE { get; set; }
    }
}
