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
    
    public partial class XB_SCENARIO
    {
        public int SID { get; set; }
        public long CONTEXT_SID { get; set; }
        public string DIMENSION { get; set; }
        public string MEMBER { get; set; }
    
        public virtual XB_CONTEXT XB_CONTEXT { get; set; }
    }
}
