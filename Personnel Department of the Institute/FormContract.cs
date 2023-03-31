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
    public partial class FormContract : Form
    {
        public FormContract()
        {
            InitializeComponent();
        }

        private void contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_Department_of_the_InstituteDataSet);

        }

        private void FormContract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_Department_of_the_InstituteDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.personnel_Department_of_the_InstituteDataSet.Contract);

        }
        private static FormContract f;
        public static FormContract fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormContract();
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
