using System;
using System.Collections.Generic;

namespace BlazorApp5.DataAccess.Dto
{
    // 获取到日期组
    public class DateGroupDto
    {
        public List<string> GetDateGroupDtos()
        {
            List<string> dtos = new List<string>();
            dtos.Add(new DateTime(2020, 7, 14, 14, 23, 40).ToString("yyyy-MM-dd"));
            dtos.Add(new DateTime(2020, 7, 15, 14, 23, 40).ToString("yyyy-MM-dd"));
            dtos.Add(new DateTime(2020, 7, 16, 14, 23, 40).ToString("yyyy-MM-dd"));
            dtos.Add(new DateTime(2020, 7, 16, 14, 23, 40).ToString("yyyy-MM-dd"));//重复日期
            dtos.Add(new DateTime(2020, 7, 17, 14, 23, 40).ToString("yyyy-MM-dd"));
            dtos.Add(new DateTime(2020, 7, 18, 14, 23, 40).ToString("yyyy-MM-dd"));
            HashSet<string> set = new HashSet<string>();
            foreach (string d in dtos)
            {
                set.Add(d);
            }
            return new List<string>(set);//去重
        }
    }
}
