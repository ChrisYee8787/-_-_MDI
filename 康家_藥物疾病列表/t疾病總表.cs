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
    
    public partial class t疾病總表
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t疾病總表()
        {
            this.t疾病診斷 = new HashSet<t疾病診斷>();
        }
    
        public string ID_Disease { get; set; }
        public Nullable<double> F2 { get; set; }
        public string DiseaseEnglishName { get; set; }
        public string DiseaseChineseName { get; set; }
        public string F5 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t疾病診斷> t疾病診斷 { get; set; }
    }
}
