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
    
    public partial class FL_MAIL_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FL_MAIL_INFO()
        {
            this.FL_FILE_INFO = new HashSet<FL_FILE_INFO>();
            this.FL_MAIL_INFO_CC = new HashSet<FL_MAIL_INFO_CC>();
        }
    
        public int SID { get; set; }
        public int OM_FUND_INFO_SID { get; set; }
        public int FL_PRINTING_COMPANY_INFO_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FL_FILE_INFO> FL_FILE_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FL_MAIL_INFO_CC> FL_MAIL_INFO_CC { get; set; }
        public virtual OM_FUND_INFO OM_FUND_INFO { get; set; }
    }
}
