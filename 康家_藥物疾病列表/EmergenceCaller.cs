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
    
    public partial class EmergenceCaller
    {
        public int fid { get; set; }
        public Nullable<int> fPatientId { get; set; }
        public string fEmergencyName { get; set; }
        public string frelation { get; set; }
        public string fPhone { get; set; }

        public virtual PatientInfo PatientInfo { get; set; }
    }
}
