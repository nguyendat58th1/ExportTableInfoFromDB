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
    
    public partial class ID_INDESIGN_COLOR_INFO
    {
        public int SID { get; set; }
        public int ORDER_SID { get; set; }
        public int SWATCH_ID { get; set; }
        public string CMYK_COLOR { get; set; }
        public string RGB_COLOR { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public string COLOR_NAME { get; set; }
        public short SPOT_COLOR_FLAG { get; set; }
    
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
    }
}
