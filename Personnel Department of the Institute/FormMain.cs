using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel_Department_of_the_Institute.Properties;


namespace Personnel_Department_of_the_Institute
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Hide();
            var authorizationForm = new AuthorizationForm();
            var result = authorizationForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Show();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
                           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                       DialogResult.Yes;
        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,ФВС,Назмутдинов Артём ,571-2,2023", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutTheProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,ФВС,Назмутдинов Артём ,571-2,2023", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void Anketa_Click(object sender, EventArgs e)
        {
            FormAnket.fd.ShowForm();
        }

        private void Contract_Click(object sender, EventArgs e)
        {
            FormContract.fw.ShowForm();
        }

        private void InformationButton_Click(object sender, EventArgs e)
        {
            FormInformation.fd.ShowForm();
        }

        private void LabourBookButton_Click(object sender, EventArgs e)
        {
            FormLabourBookData.fw.ShowForm();
        }

        private void toolStripButtonSQL_Click(object sender, EventArgs e)
        {
            FormSQL.fw.Show();
        }
    }
}
