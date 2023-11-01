using StudentsRegistration.DataContext;
using StudentsRegistration.Models;

namespace StudentsRegistration.Repositories;

public class StudentService : IStudentInterface
{
    private ApplicationDbContext dbContext = new();

    public void AddStudent(Student student)
    {
        dbContext.Students.Add(student);
        dbContext.SaveChanges();
    }

    public void DeleteStudent(int id)
    {
       var student = GetStudent(id);
        dbContext.Students.Remove(student);
        dbContext.SaveChanges();    
    }
    public Student GetStudent(int id)
    {
      return  dbContext.Students.FirstOrDefault(s => s.Id == id);
    }
    public List<Student> GetStudents()
    {
        return dbContext.Students.ToList();
    }

    public List<Student> SearchStudents(string txt)
    {
        var cur = GetStudents();
        return cur.Where(i => i.FullName.ToLower().Contains(txt.ToLower())).ToList();

    }

    public void UpdateStudent(Student student)
    {
        dbContext.Students.Update(student);
        dbContext.SaveChanges();
    }
    //StudentServices implementation    
}