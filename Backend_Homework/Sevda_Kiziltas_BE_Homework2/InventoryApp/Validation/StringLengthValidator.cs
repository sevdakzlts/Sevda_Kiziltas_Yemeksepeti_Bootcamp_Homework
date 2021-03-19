using System.ComponentModel.DataAnnotations;
using FluentValidation;
using InventoryApp.Controllers;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace InventoryApp.Validation
{
    public class StringLengthValidator : ValidationAttribute
    {
        private int _minLength;

        public StringLengthValidator(int minLength)
        {
            _minLength = minLength;
        }

        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            InventoryController.SearchModel searchModel =
                (InventoryController.SearchModel) validationContext.ObjectInstance;
            if (searchModel.name.Length < _minLength)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(FormatErrorMessage(validationContext.MemberName));
            }

            return System.ComponentModel.DataAnnotations.ValidationResult.Success;
        }


       
    }
}
