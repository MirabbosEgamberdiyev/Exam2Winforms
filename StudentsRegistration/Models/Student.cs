namespace StudentsRegistration.Models;

public class Student
{
    //student model properties
    
    public int Id { get; set; }
    
    public string FullName { get; set; } = string.Empty;

    public int Age { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
}