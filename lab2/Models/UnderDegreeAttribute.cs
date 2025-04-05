using System.ComponentModel.DataAnnotations;
using lab2.ViewModel;
using Microsoft.IdentityModel.Tokens;

namespace lab2.Models
{
    public class UnderDegreeAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int minDegree = (int)value;
            CourseWithLstOfDeptViewModel courseWithDeptListRequest = (CourseWithLstOfDeptViewModel)validationContext.ObjectInstance;
            if (minDegree <= courseWithDeptListRequest.Degree) { return ValidationResult.Success; }
            return new ValidationResult("Minimum degree must be equal or less the the degree (> <)");
            
        }
    }
}
