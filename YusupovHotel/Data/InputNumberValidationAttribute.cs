using System;
using System.ComponentModel.DataAnnotations;


namespace YusupovHotel.Data
{
    public class InputNumberValidationAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Value = int.Parse(value.ToString());
            if (Mongo.GetAllRoom().FirstOrDefault(x => x.RoomNumber == Value) == null)
                return null;
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
