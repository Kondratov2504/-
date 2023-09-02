using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяНовыйВариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void subjectButton_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
        }

        private void lessonButton_Click(object sender, EventArgs e)
        {
            LessonForm lessonForm = new LessonForm();
            lessonForm.Show();
        }

        private void studentAchievementButton_Click(object sender, EventArgs e)
        {
            StudentAchievementForm studentAchievementForm = new StudentAchievementForm();
            studentAchievementForm.Show();
        }
    }
}
