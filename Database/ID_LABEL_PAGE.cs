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
    
    public partial class ID_LABEL_PAGE
    {
        public int SID { get; set; }
        public int PAGE_INFO_SID { get; set; }
        public string LABEL { get; set; }
    
        public virtual ID_PAGE_INFO ID_PAGE_INFO { get; set; }
    }
}
