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
    
    public partial class XB_ENTITY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XB_ENTITY()
        {
            this.XB_STR_ITEM = new HashSet<XB_STR_ITEM>();
        }
    
        public int SID { get; set; }
        public int BASIC_SID { get; set; }
        public string SCHEME_REF { get; set; }
        public string IDENTIFER { get; set; }
        public string SEGMENT { get; set; }
    
        public virtual XB_BASIC_INFO XB_BASIC_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XB_STR_ITEM> XB_STR_ITEM { get; set; }
    }
}
