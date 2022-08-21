using BlazorApp3.DataAccess.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.DataAccess.Dto
{
    public class UrbanAreaDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string City { get; set; }

        [Required]
        [StringLength(256)]
        public string Country { get; set; }

        public static Func<UrbanArea, UrbanAreaDto> UrbanAreaFunc = (urbanArea) =>
            new UrbanAreaDto
            {
                Id = urbanArea.Id,
                City = urbanArea.City,
                Country = urbanArea.Country
            };
    }
}
