using BlazorApp6.DataAccess.Commons;
using BlazorApp6.DataAccess.Model;
using System.Collections.Generic;

namespace BlazorApp6.Utils
{
    public class DateGrupTool
    {
        private static Dictionary<string, int> dates = new Dictionary<string, int>();
        private static List<Patient> patients = null;
        public static Dictionary<string, int> GetDates()
        {
            dates.Clear();
            patients = CommonsData.patients;
            int i = 2;// 计数从2开始
            foreach (Patient item in patients)
            {
                if (!dates.ContainsKey(item.ApplicationTime.ToString("yyyy-MM-dd")))
                    dates.Add(item.ApplicationTime.ToString("yyyy-MM-dd"), i++);
            }
            return dates;
        }
    }
}
