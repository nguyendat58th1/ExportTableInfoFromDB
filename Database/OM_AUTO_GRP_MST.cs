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
    
    public partial class OM_AUTO_GRP_MST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OM_AUTO_GRP_MST()
        {
            this.OM_AUTO_GRP_JOB_REF = new HashSet<OM_AUTO_GRP_JOB_REF>();
        }
    
        public int SID { get; set; }
        public string GRP_NAME { get; set; }
        public int COMPANY_SID { get; set; }
        public bool AUTO_GRP_TYPE { get; set; }
        public System.DateTime SUBMIT_DATE { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OM_AUTO_GRP_JOB_REF> OM_AUTO_GRP_JOB_REF { get; set; }
        public virtual OM_COMPANY_INFO OM_COMPANY_INFO { get; set; }
    }
}
