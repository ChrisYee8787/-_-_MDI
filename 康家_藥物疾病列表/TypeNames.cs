//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 康家_藥物疾病列表
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeNames
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeNames()
        {
            this.CounsultTypeRecord = new HashSet<CounsultTypeRecord>();
            this.tFunctionBrige = new HashSet<tFunctionBrige>();
            this.tGroupActivityClassTheme = new HashSet<tGroupActivityClassTheme>();
        }
    
        public int fid { get; set; }
        public Nullable<int> TypeNameId { get; set; }
        public string TypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CounsultTypeRecord> CounsultTypeRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tFunctionBrige> tFunctionBrige { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tGroupActivityClassTheme> tGroupActivityClassTheme { get; set; }
    }
}
