using BlazorApp4.DataAccess.Model;
using System;
using System.Collections.Generic;

namespace BlazorApp4.DataAccess.Service
{
    public class PatientService
    {
        public Patient GetPatient()
        {
            return new Patient()
            {
                Name = "Trump",
                Gender = "男",
                Age = 84,
                PatientNo = "1",
                ApplicationDepartment = "儿科",
                ApplicationDoctor = "Jack",
                ApplicationTime = DateTime.Now,
                SimpleNumber = "1001",
                BarCodeNumber = "1001",
                SimpleType = "血清",
                SimplingTime = DateTime.Now,
                SubmitTime = DateTime.Now,
                ReportTime = DateTime.Now,
                Reporter = "Jack",
                ReportRemarks = "正常"
            };
        }
    }
}
