using System;

namespace BlazorApp5.DataAccess.Model
{
    public class Patient
    {
        public string Name { get; set; }//患者姓名
        public string Gender { get; set; }//患者性别
        public int Age { get; set; }//患者年龄
        public string PatientNo { get; set; }//病例号
        public string ApplicationDepartment { get; set; }//申请科室
        public string ApplicationDoctor { get; set; }//申请医生
        public DateTime ApplicationTime { get; set; }//申请时间
        public string SimpleNumber { get; set; }//样本号
        public string BarCodeNumber { get; set; }//条码号
        public string SimpleType { get; set; }//样本类型
        public DateTime SimplingTime { get; set; }//采样时间
        public DateTime SubmitTime { get; set; }//送检时间
        public DateTime ReportTime { get; set; }//报告时间
        public string Reporter { get; set; }//报告人
        public string ReportRemarks { get; set; }//报告备注
    }
}
