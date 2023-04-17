using System.ComponentModel.DataAnnotations;
using YusupovHotel.Data;

namespace YusupovHotel.Shared
{
    public class InputNumberValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Value = int.Parse(value.ToString());
            if (Mongo.GetAllRooms().FirstOrDefault(x => x.Number == Value) == null)
                return null;
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
