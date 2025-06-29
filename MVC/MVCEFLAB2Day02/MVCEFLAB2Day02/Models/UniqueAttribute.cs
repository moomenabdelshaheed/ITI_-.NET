using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MVCEFLAB2Day02.Models;

namespace MVCEFLAB2Day02.Models
{
    public class UniqueAttribute :ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)

        {
            ITIcontext context = new ITIcontext();
            string Name = value.ToString();
            var courseObj = (Course)validationContext.ObjectInstance;
            Course course = context.Courses.FirstOrDefault(n => n.Name == Name&&n.DepartmentID==courseObj.DepartmentID);
            if (course == null)
            {
                return ValidationResult.Success;
            }
            else

                return new ValidationResult("The Name is not Unique");
        }
    }
}
