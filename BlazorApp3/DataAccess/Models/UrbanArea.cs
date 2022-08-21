using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.DataAccess.Models
{
    public class UrbanArea
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string City { get; set; }

        [Required]
        [StringLength(256)]
        public string Country { get; set; }
    }
}
