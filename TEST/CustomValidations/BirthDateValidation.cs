using System.ComponentModel.DataAnnotations;

namespace TEST.CustomValidations
{
    
    
        public class BirthDateValidation : ValidationAttribute
        {
            protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
            {
                DateTime date = (DateTime)value;
                if (date >= DateTime.Now || date < DateTime.Now.AddYears(-99))
                {
                    return new ValidationResult("Invalid Birthdate");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
        }

    
}
