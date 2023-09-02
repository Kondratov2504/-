using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КурсоваяНовыйВариант.subjectDataSetTableAdapters;

namespace КурсоваяНовыйВариант
{
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            this.classTableAdapter1.Fill(this.classLessonDataSet.Class);
            this.teacherTableAdapter.Fill(this.teacherDataSet.Teacher);
            this.lessonTableAdapter.Fill(this.lesson2DataSet.Lesson);
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex; // берём индекс столбца из dataGridView1
            int row = e.RowIndex;// берём индекс строки из dataGridView1

            if (CheckComboBoxCell(row, column))
            { // если выбранный столбец третий и количество строк у dataGridView1 больше 0
                DataGridViewComboBoxCell comboBox =
                    (DataGridViewComboBoxCell)dataGridView1.
                    Rows[row].Cells[column];// получаем DataGridViewComboBoxCell при нажатии на выбранную ячейку
                textBox1.Text = "combo" + column + comboBox.Value;
                if (comboBox.Value != null) // если значение ячейки равно 0
                {
                    int fkColumn = column - 1;
                    dataGridView1.Rows[row].Cells[fkColumn].Value = comboBox.Value;// выбирается значение ячейки сверху
                }
            }
        }

        private bool CheckComboBoxCell(int row, int column)
        {
            return dataGridView1.Rows.Count > 0
                && dataGridView1.Rows[row].Cells[column] is DataGridViewComboBoxCell;
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int column = dataGridView1.CurrentCell.ColumnIndex;
            int row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.IsCurrentCellDirty
                && CheckComboBoxCell(row, column))
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            this.lessonBindingSource.EndEdit();
            this.lessonTableAdapter.Update(this.lesson2DataSet.Lesson);
            MessageBox.Show("Сохранено");
            this.lessonTableAdapter.Fill(this.lesson2DataSet.Lesson);
        }
    }
}
