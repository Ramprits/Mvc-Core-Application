using System.ComponentModel.DataAnnotations;

namespace Mvc_Core_Application.Models.EmployeeViewModel
{
    public class Employee : EntityClass
    {
        
          public string Name { get; set; }
          public string  Gender { get; set; }
          public string Address { get; set; }
          [Display(Name="Email Address"),DataTypeAttribute(DataType.EmailAddress)]
          public string Email { get; set; }
          public string Mobile { get; set; }
          public string Image { get; set; }
    }
}