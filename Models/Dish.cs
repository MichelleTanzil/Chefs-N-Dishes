using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace chef_and_dishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Display (Name = "Name of dish")]
        [Required]
        public string NameOfDish { get;set; }

        [Required]
        [Range(1, 5)]
        public int Tastiness { get;set; }

        [Display (Name = "# of Calories")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0.")]
        public int Calories { get;set; }

        [Required]
        public string Description{ get;set; }

        public int ChefId { get;set; }

        public Chef Creater { get;set; }

        [Required]
        public DateTime CreatedAt { get;set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
    }
}