using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 康家_藥物疾病列表
{
    public class cDisease
    {
        public int dis_PatientID { get; set; }
        public string dis_DiseaseID { get; set; }
      //  public string dis_類別{ get; set; }
        public string dis_科別 { get; set; }
        public string dis_中文名稱 { get; set; }
        public string dis_備註 { get;set; }
    }
}
