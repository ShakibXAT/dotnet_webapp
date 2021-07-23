using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(10)]
        public string Name { get; set; }
    }
}