using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КурсоваяНовыйВариант.teacherDataSetTableAdapters;

namespace КурсоваяНовыйВариант
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.studentsDataSet.Student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(studentsDataSet.Student);
            MessageBox.Show("Сохранено");
            this.studentTableAdapter.Fill(this.studentsDataSet.Student);
        }
    }
}
