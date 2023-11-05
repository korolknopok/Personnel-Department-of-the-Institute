using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel_Department_of_the_Institute.Properties;

namespace Personnel_Department_of_the_Institute
{
    public partial class FormSQL : Form
    {
        private string _request;
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
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM [Information_about_teachers]");
        }

        private void radioButtonLabour_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewExample.DataSource = FillDataGridView(@"SELECT * FROM Labour_book_data");
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWorker.Text))
            {
                MessageBox.Show("Обязательно укажите фамилию необходимого сотрудника.\nДопустим ввод первых символов.",
                    "Внимание", MessageBoxButtons.OK,
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

            string sqlSelect = "SELECT * FROM Contract";
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
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    checkBoxMore.Checked = false;
                    return;
                }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0)
                MessageBox.Show("Нет значений!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
                sqlSelect = @"SELECT * FROM (SELECT SurName + ' ' + FirstName + ' ' + MiddleName AS fio FROM Anketa ) AS a ";


            else if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"SELECT * FROM Contract WHERE List_of_disciplines = 'Программирование' AND Load_in_the_current_year_number_of_hours > (SELECT AVG(Load_in_the_current_year_number_of_hours) FROM Contract)";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection connection = new
                SqlConnection(Properties.Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@number", SqlDbType.Int).Value =
                    int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0)
                MessageBox.Show("Нет значений!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearValueFromElements()
        {
            textBoxId_dish.Text = null;
            textBoxName_dish.Text = null;
            textBoxType_dish.Text = null;
            textBoxType.Text = null;
            textBoxPrice_dish.Text = null;
            textBoxWeight_dish.Text = null;
            textBoxIdAnketa.Text = null;
        }

        void InsertDish()
        {
            _request = @"USE [Personnel Department of the Institute]
                            INSERT INTO Contract(Pedagogic_stage, List_of_disciplines, Load_in_the_current_year_number_of_hours, Date_of_conclusion_of_the_contract, Contract_end_date, Id_Anketa)
                            VALUES (@Pedagogic_stage,@List_of_disciplines,@Load_in_the_current_year_number_of_hours,@Date_of_conclusion_of_the_contract,@Contract_end_date,@Id_Anketa)
                            ";

            var connection = new SqlConnection(Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            var command = connection.CreateCommand();
            command.CommandText = _request;
            command.Parameters.Add("@Pedagogic_stage", SqlDbType.Int).Value = textBoxName_dish.Text;
            command.Parameters.Add("@List_of_disciplines", SqlDbType.NVarChar).Value = textBoxType_dish.Text;
            command.Parameters.Add("@Load_in_the_current_year_number_of_hours", SqlDbType.Int).Value = textBoxType.Text;
            command.Parameters.Add("@Date_of_conclusion_of_the_contract", SqlDbType.NVarChar).Value = textBoxPrice_dish.Text;
            command.Parameters.Add("@Contract_end_date", SqlDbType.NVarChar).Value = textBoxWeight_dish.Text;
            command.Parameters.Add("@Id_Anketa", SqlDbType.Int).Value = textBoxIdAnketa.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            _request = "SELECT * FROM Contract";
            dataGridViewDish.DataSource = FillDataGridView(_request);
        }

        private void buttonSelectDishes_Click(object sender, EventArgs e)
        {
            dataGridViewDish.DataSource = FillDataGridView("SELECT * FROM Contract");
            
        }
        void UpdateDish()
        {
            _request = @"UPDATE [Information about teachers]
                        SET Position_Degree_title = @Position_Degree_title,
                        Name_of_the_department_or_department = @Name_of_the_department_or_department
                        WHERE Id_Teach = 2
                        ";
            var connection = new SqlConnection(Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            var command = connection.CreateCommand();
            command.CommandText = _request;
            command.Parameters.Add("@Position_Degree_title", SqlDbType.NVarChar).Value = textBoxDegree.Text;
            command.Parameters.Add("@Name_of_the_department_or_department", SqlDbType.NVarChar).Value = textBoxdepartment.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            _request = "SELECT * FROM [Information about teachers]";
            dataGridViewDish.DataSource = FillDataGridView(_request);
        }

        void DeleteDish()
        {
            _request = @"DELETE FROM [Information about teachers] WHERE Id_Teach = @Id_Teach";
            var connection = new SqlConnection(Settings.Default.Personnel_Department_of_the_InstituteConnectionString);
            var command = connection.CreateCommand();
            command.CommandText = _request;
            command.Parameters.Add("@Id_Teach", SqlDbType.Int).Value = textBoxId_dish.Text;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            _request = "SELECT * FROM [Information about teachers]";
            dataGridViewDish.DataSource = FillDataGridView(_request);
        }

        private void radioButtonDelete_dish_CheckedChanged(object sender, EventArgs e)
        {
            textBoxId_dish.ReadOnly = false;
            panelDish.Enabled = false;
            buttonFind.Visible = false;
            ClearValueFromElements();
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_dish.Checked)
                InsertDish();
            else
            if (radioButtonUpdate_dish.Checked)
                UpdateDish();
            else
            if (radioButtonDelete_dish.Checked)
                DeleteDish();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radioButtonInsert_dish_CheckedChanged(object sender, EventArgs e)
        {
            textBoxId_dish.ReadOnly = true;
            buttonFind.Visible = false;
            ClearValueFromElements();
        }

        private void radioButtonUpdate_dish_CheckedChanged(object sender, EventArgs e)
        {
            textBoxId_dish.ReadOnly = false;
            buttonFind.Visible = true;
            ClearValueFromElements();
        }
    }
}

