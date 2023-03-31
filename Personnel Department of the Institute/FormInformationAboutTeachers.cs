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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void information_about_teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.information_about_teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_Department_of_the_InstituteDataSet);

        }

        private void Information_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_Department_of_the_InstituteDataSet.Information_about_teachers". При необходимости она может быть перемещена или удалена.
            this.information_about_teachersTableAdapter.Fill(this.personnel_Department_of_the_InstituteDataSet.Information_about_teachers);

        }

        private static FormInformation f;
        public static FormInformation fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormInformation();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
