using System;
using System.ComponentModel.DataAnnotations;
namespace chef_and_dishes
{
  public class FutureDateAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

      // You first may want to unbox "value" here and cast to to a DateTime variable!
      DateTime CurrentTime = DateTime.Now;
      int CurrentYear = DateTime.Now.Year;
      DateTime valueYear = (DateTime)value;
      // if(value == null)
      // {

      // }
      if ((DateTime)value > CurrentTime)
      {
        return new ValidationResult("Date of birth must be in the past");
      }
      if (CurrentYear - valueYear.Year < 18)
      {
        return new ValidationResult("You must be at least 18 years old!");
      }
      return ValidationResult.Success;
    }
  }
}