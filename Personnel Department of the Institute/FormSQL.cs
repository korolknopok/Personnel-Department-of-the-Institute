using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department_of_the_Institute
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;
        public static FormSQL fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        DataTable FillDataGridView(string sqlSelect)
        {

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        private void radioButtonAnketa_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM Anketa");
        }

        private void radioButtonContract_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM Contract");
        }

        private void radioButtonTeacher_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM [Information about teachers]");
        }

        private void radioButtonLabour_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM Labour_book_data");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (checkBoxMore.Checked)
                sqlSelect += " HAVING Sum(Количество*Цена*(1-Скидка)) >@amount";
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Sum(Количество*Цена*(1-Скидка)) desc";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxWorker.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                   Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
