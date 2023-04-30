using System.ComponentModel.DataAnnotations;

namespace YusupovHotel.Data
{
    public class EmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var lowerValue = value.ToString().ToLower();
            if (Mongo.FindUser(lowerValue) == null && Mongo.FindClient(lowerValue) == null)
                return null;
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
