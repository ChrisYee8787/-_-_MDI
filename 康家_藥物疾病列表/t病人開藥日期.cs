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
    
    public partial class t病人開藥日期
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t病人開藥日期()
        {
            this.t病人用藥資訊 = new HashSet<t病人用藥資訊>();
        }
    
        public int ID_GetMedicineDate { get; set; }
        public int fid { get; set; }
        public string Date_GetMedicine { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t病人用藥資訊> t病人用藥資訊 { get; set; }
    }
}
