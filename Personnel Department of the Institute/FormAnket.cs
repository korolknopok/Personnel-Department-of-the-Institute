using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Department_of_the_Institute
{
    public partial class FormAnket : Form
    {
        public FormAnket()
        {
            InitializeComponent();
        }

        private void anketaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.anketaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_Department_of_the_InstituteDataSet);

        }

        private void FormAnket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_Department_of_the_InstituteDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.personnel_Department_of_the_InstituteDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_Department_of_the_InstituteDataSet.Anketa". При необходимости она может быть перемещена или удалена.
            this.anketaTableAdapter.Fill(this.personnel_Department_of_the_InstituteDataSet.Anketa);

        }
        private static FormAnket f;
        public static FormAnket fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAnket();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void SearchToolStripButton_Click(object sender, EventArgs e)
        {
            {
                if (TextBoxStripTool.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int indexPos;
                try
                {
                    indexPos =
                        anketaBindingSource.Find("SurName",
                            TextBoxStripTool.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка поиска \n" + err.Message);
                    return;
                }

                if (indexPos > -1)
                    anketaBindingSource.Position = indexPos;
                else
                {
                    MessageBox.Show("Таких сотрудников нет", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    anketaBindingSource.Position = 0;
                }
            }
        }

    }
}
