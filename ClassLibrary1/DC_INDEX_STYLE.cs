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
    
    public partial class DC_INDEX_STYLE
    {
        public int SID { get; set; }
        public int JOB_SID { get; set; }
        public short DISPLAY_LEVEL { get; set; }
        public string FONT_FAMILY { get; set; }
        public string FONT_SIZE { get; set; }
        public string LINE_HEIGHT { get; set; }
        public string MARGIN_LEFT { get; set; }
        public string MARGIN_TOP { get; set; }
        public string MARGIN_BOTTOM { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public string HANGING_INDENT { get; set; }
        public string BOLD_TYPE { get; set; }
    
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
    }
}
