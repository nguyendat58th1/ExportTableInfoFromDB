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
    
    public partial class OM_USER_LOGIN_INFO
    {
        public int USER_SID { get; set; }
        public string GUID { get; set; }
        public System.DateTime LOGIN_DATE { get; set; }
        public System.DateTime LAST_OPERATION_DATE { get; set; }
    
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
    }
}
