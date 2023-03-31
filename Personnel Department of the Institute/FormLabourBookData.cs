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
    public partial class FormLabourBookData : Form
    {
        public FormLabourBookData()
        {
            InitializeComponent();
        }

        private void labour_book_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.labour_book_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnel_Department_of_the_InstituteDataSet);

        }

        private void FormLabourBookData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personnel_Department_of_the_InstituteDataSet.Labour_book_data". При необходимости она может быть перемещена или удалена.
            this.labour_book_dataTableAdapter.Fill(this.personnel_Department_of_the_InstituteDataSet.Labour_book_data);

        }
        private static FormLabourBookData f;
        public static FormLabourBookData fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormLabourBookData();
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
