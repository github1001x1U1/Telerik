using BlazorApp3.DataAccess.Dto;
using System.Collections.Generic;

namespace BlazorApp3.DataAccess.Services
{
    public class UrbanAreaService
    {
        public List<UrbanAreaDto> GetUrbanAreas()
        {
            List<UrbanAreaDto> result = new List<UrbanAreaDto>();
            result.Add(new UrbanAreaDto { Id = 1, City = "纽约", Country = "美国" });
            result.Add(new UrbanAreaDto { Id = 2, City = "慕尼黑", Country = "德国" });
            result.Add(new UrbanAreaDto { Id = 3, City = "东京", Country = "日本" });
            return result;
        }
    }
}
