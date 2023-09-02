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
    public partial class StudentAchievementForm : Form
    {
        public StudentAchievementForm()
        {
            InitializeComponent();
        }

        private void StudentAchievementForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentAchievementDataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.studentAchievementDataSet.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentAchievementDataSet.StudentAchievement". При необходимости она может быть перемещена или удалена.
            this.studentAchievementTableAdapter.Fill(this.studentAchievementDataSet.StudentAchievement);

        }
    }
}
