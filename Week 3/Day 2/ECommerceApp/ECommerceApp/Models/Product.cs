using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}