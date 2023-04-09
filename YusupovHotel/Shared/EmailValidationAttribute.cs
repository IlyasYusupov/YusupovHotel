using System.ComponentModel.DataAnnotations;
using YusupovHotel.Data;

namespace YusupovHotel.Shared
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
