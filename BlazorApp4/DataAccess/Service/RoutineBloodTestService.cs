using BlazorApp4.DataAccess.Model;
using System.Collections.Generic;

namespace BlazorApp4.DataAccess.Service
{
    public class RoutineBloodTestService
    {
        public List<RoutineBloodTest> GetRoutineBloodTestList()
        {
            List<RoutineBloodTest> routines = new List<RoutineBloodTest>();
            routines.Add(new RoutineBloodTest()
            {
                ProjectName = "尿酸",
                Result = "550",
                Company = "mol/L",
                ReferenceValue = "40~420",
                Methodology = "占位",
                TestingEquipment = "AX-32 Pro"
            });
            routines.Add(new RoutineBloodTest()
            {
                ProjectName = "谷丙转氨酶",
                Result = "40",
                Company = "mol/L",
                ReferenceValue = "10~50",
                Methodology = "占位",
                TestingEquipment = "CV-10 Pro"
            });
            return routines;
        }
    }
}
