using StudentsRegistration.DataContext;
using StudentsRegistration.Models;
using StudentsRegistration.Repositories;

namespace StudentsRegistration.StudentForms;

public partial class AddStudent : Form
{
    private IStudentInterface studentInterface;
    public AddStudent()
    {
        InitializeComponent();
        studentInterface = new StudentService();
    }

    private void cancel_btn_Click(object sender, EventArgs e)
    {
        //implement cancel button
        this.Close();
    }

    private void save_btn_Click(object sender, EventArgs e)
    {
        //implement save btn
        using var dbContext = new ApplicationDbContext();
        dbContext.Students.Add(new Student()
        {
            FullName = fullname_textbox.Text,
            Age = int.Parse(age_textbox.Text),
            PhoneNumber = phoneNumber_textbox.Text,
            Address = address_textbox.Text,
        });
        dbContext.SaveChanges();
        MessageBox.Show("Ma'lumot mofaqiyatli qo'shildi ");

        this.Close();
        Refresh();
    }


}