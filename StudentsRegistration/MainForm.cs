using StudentsRegistration.DataContext;
using StudentsRegistration.Models;
using StudentsRegistration.Repositories;
using StudentsRegistration.StudentForms;

namespace StudentsRegistration
{
    public partial class MainForm : Form
    {
        //id for selected Student of students table
        private int selectedStudentId = 0;
        private IStudentInterface studentInterface;
        private ApplicationDbContext dbContext;
        public void Refresh()
        {
            studentInterface = new StudentService();
            studentsTable.DataSource = studentInterface.GetStudents();
        }
        public MainForm()
        {
            InitializeComponent();
            studentInterface = new StudentService();
            Refresh();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            //implement refresh data
            Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //implement add student using open add form
            AddStudent add = new();
            add.ShowDialog();
            Refresh();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            //implement edit student using open edit form
            EditStudent edit = new(selectedStudentId);
            edit.ShowDialog();
        }


        // Id orqali topib o'chirish 
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete this item?",
                                                       "Warning",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                studentInterface.DeleteStudent(selectedStudentId);
                MessageBox.Show("Successfully deleted!");
                selectedStudentId = 0;
               Refresh();
            }
        }

        // Id raqamni olish 

        private void studentsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedStudentId = int.Parse(studentsTable.SelectedRows[0].Cells[0].Value.ToString() ?? "0");
            
        }


        // Studentni qidirish
        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            // Implement filter for student table

            if (!string.IsNullOrEmpty(search_textbox.Text))
            {
                studentsTable.DataSource = studentInterface.SearchStudents(search_textbox.Text);
            }
            else
            {
                Refresh(); // Refresh the table with all students
            }
        }





        private void studentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}