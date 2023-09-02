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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "subjectDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.subjectDataSet.Subject);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            subjectBindingSource.EndEdit();
            subjectTableAdapter.Update(subjectDataSet.Subject);
            MessageBox.Show("Сохранено");
            this.subjectTableAdapter.Fill(this.subjectDataSet.Subject);
        }
    }
}
