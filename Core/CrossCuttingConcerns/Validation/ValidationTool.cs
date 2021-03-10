using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool 
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);// Gelen Car için Car türünde Doğrulama Context'i oluştur.
            //CarValidator carValidator = new CarValidator();// Ne ile doğrulanacak
            var result = validator.Validate(context);// CarValidator contexti doğrulayacak

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
