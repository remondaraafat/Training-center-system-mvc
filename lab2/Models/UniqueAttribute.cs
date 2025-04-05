using System.ComponentModel.DataAnnotations;
using lab2.ViewModel;

namespace lab2.Models
{
    public class UniqueAttribute:ValidationAttribute
    {

        
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Context Context = validationContext.GetService<Context>();
            string text = value.ToString();
            CourseWithLstOfDeptViewModel courseWithDeptListRequest = (CourseWithLstOfDeptViewModel)validationContext.ObjectInstance;

            Course courseFromDatabase = Context.Courses.FirstOrDefault(c => c.Name == text);
            if (courseFromDatabase == null) { return ValidationResult.Success; }

            return new ValidationResult("Name Already Exist :(");
        }
    }
}
