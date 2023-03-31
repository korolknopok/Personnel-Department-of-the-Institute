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

    }
}
