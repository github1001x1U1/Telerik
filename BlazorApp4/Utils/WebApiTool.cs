using BlazorApp4.DataAccess.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace BlazorApp4.Utils
{
    public class WebApiTool
    {
        public static List<Patient> GetWebData(string str)
        {
            JObject j = JObject.Parse(str);
            string jst = j["content"].ToString();
            JArray r1 = JArray.Parse(jst);
            //封装病例信息
            List<Patient> patients = new List<Patient>();
            for (int i = 0; i < r1.Count; i++)
            {
                patients.Add(new Patient()
                {
                    //固定存在
                    Name = r1[i]["PATIENT_NAME"].ToString(),
                    Gender = r1[i]["GENDER"].ToString(),
                    Age = int.Parse(r1[i]["AGE"].ToString()),
                    PatientNo = r1[i]["PATIENT_ID"].ToString(),
                    //申请医生
                    ApplicationDepartment = r1[i]["DEPARTMENT"].ToString(),
                    ApplicationDoctor = r1[i]["input_doctor"].ToString(),
                    ApplicationTime = DateTime.Parse(r1[i]["GET_DATE"].ToString()),
                    //样本信息
                    SimpleNumber = r1[i]["SAMPLE_NO"].ToString(),
                    BarCodeNumber = r1[i]["BARCODE"].ToString(),
                    SimpleType = r1[i]["SAMPLE_TYPE"].ToString(),
                    SimplingTime = DateTime.Parse(r1[i]["SAMPLING_DATE"].ToString()),
                    SubmitTime = DateTime.Parse(r1[i]["test_date"].ToString()),
                    //报告信息
                    Reporter=r1[i]["TEST_DOCTOR"].ToString(),
                    ReportTime = DateTime.Parse(r1[i]["REPORT_DATE"].ToString()),
                    ReportRemarks = r1[i]["PRINT_FLAG"].ToString()
                });
            }
            return patients;
        }
    }
}
