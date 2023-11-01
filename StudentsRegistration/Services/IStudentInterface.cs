using StudentsRegistration.Models;

namespace StudentsRegistration.Repositories;

public interface IStudentInterface
{
    //IStudentInterface implementation
    List<Student> GetStudents();
    Student GetStudent(int id);
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
    List<Student> SearchStudents(string txt);

}