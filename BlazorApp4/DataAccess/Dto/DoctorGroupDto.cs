using System.Collections.Generic;

namespace BlazorApp4.DataAccess.Dto
{
    // 获取到医生名字组
    public class DoctorGroupDto
    {
        public List<string> GetDoctorDtos()
        {
            List<string> dtos = new List<string>();
            dtos.Add("Jack");
            dtos.Add("Mary");
            dtos.Add("Rogan");
            dtos.Add("Jessica");
            return dtos;
        }
    }
}
