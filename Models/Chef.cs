using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace chef_and_dishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get;set; }

        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Invalid")]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [FutureDate]
        [Required]
        [Display (Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Dish> CreatedDishes { get; set; }
        
        [Required]
        public DateTime CreatedAt { get;set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
    }
}