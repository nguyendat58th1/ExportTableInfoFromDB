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
    
    public partial class FL_PRINTING_COMPANY_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FL_PRINTING_COMPANY_INFO()
        {
            this.FL_COMPANY_RELATION = new HashSet<FL_COMPANY_RELATION>();
        }
    
        public int SID { get; set; }
        public string PRINTING_COMPANY_NAME { get; set; }
        public bool INVALIDATED { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FL_COMPANY_RELATION> FL_COMPANY_RELATION { get; set; }
    }
}