using StudentsRegistration.DataContext;
using StudentsRegistration.Models;
using StudentsRegistration.Repositories;

namespace StudentsRegistration.StudentForms;

public partial class EditStudent : Form
{
    //Current Student
    private Student student = new();
    private IStudentInterface studentInterface;
    private StudentService studentService = new();
    private int id;
    public EditStudent(int studentId)
    {
        InitializeComponent();
        studentInterface = new StudentService();
        //student = studentService.GetById(studentId);
        this.id = studentId;
    }

    private void cancel_btn_Click(object sender, EventArgs e)
    {
        this.Close();
        //implement cancel button
    }

    private void save_btn_Click(object sender, EventArgs e)
    {
        //implement save btn
        student.FullName=fullname_textbox.Text;
        student.Age = int.Parse(age_textbox.Text);
        student.PhoneNumber = phoneNumber_textbox.Text;
        student.Address= address_textbox.Text;
        studentService.UpdateStudent(student);
        MessageBox.Show("Taxrirlash mofaqyatli yakunlandi");
        this.Close();

        

    }

    private void EditStudent_Load(object sender, EventArgs e)
    {
        student = studentService.GetStudent(id);
        fullname_textbox.Text = student.FullName;
        age_textbox.Text = student.Age.ToString();
        phoneNumber_textbox.Text= student.PhoneNumber;
        address_textbox.Text = student.Address;
    }
}