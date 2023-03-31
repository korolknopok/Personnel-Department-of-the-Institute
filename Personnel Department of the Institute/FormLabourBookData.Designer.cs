namespace Personnel_Department_of_the_Institute
{
    partial class FormLabourBookData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLabourBookData));
            this.personnel_Department_of_the_InstituteDataSet = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSet();
            this.labour_book_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labour_book_dataTableAdapter = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.Labour_book_dataTableAdapter();
            this.tableAdapterManager = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager();
            this.labour_book_dataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.labour_book_dataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.labour_book_dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataBindingNavigator)).BeginInit();
            this.labour_book_dataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personnel_Department_of_the_InstituteDataSet
            // 
            this.personnel_Department_of_the_InstituteDataSet.DataSetName = "Personnel_Department_of_the_InstituteDataSet";
            this.personnel_Department_of_the_InstituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labour_book_dataBindingSource
            // 
            this.labour_book_dataBindingSource.DataMember = "Labour_book_data";
            this.labour_book_dataBindingSource.DataSource = this.personnel_Department_of_the_InstituteDataSet;
            // 
            // labour_book_dataTableAdapter
            // 
            this.labour_book_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnketaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.Information_about_teachersTableAdapter = null;
            this.tableAdapterManager.Labour_book_dataTableAdapter = this.labour_book_dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // labour_book_dataBindingNavigator
            // 
            this.labour_book_dataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.labour_book_dataBindingNavigator.BindingSource = this.labour_book_dataBindingSource;
            this.labour_book_dataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.labour_book_dataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.labour_book_dataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.labour_book_dataBindingNavigatorSaveItem});
            this.labour_book_dataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.labour_book_dataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.labour_book_dataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.labour_book_dataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.labour_book_dataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.labour_book_dataBindingNavigator.Name = "labour_book_dataBindingNavigator";
            this.labour_book_dataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.labour_book_dataBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.labour_book_dataBindingNavigator.TabIndex = 0;
            this.labour_book_dataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // labour_book_dataBindingNavigatorSaveItem
            // 
            this.labour_book_dataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.labour_book_dataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("labour_book_dataBindingNavigatorSaveItem.Image")));
            this.labour_book_dataBindingNavigatorSaveItem.Name = "labour_book_dataBindingNavigatorSaveItem";
            this.labour_book_dataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.labour_book_dataBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.labour_book_dataBindingNavigatorSaveItem.Click += new System.EventHandler(this.labour_book_dataBindingNavigatorSaveItem_Click);
            // 
            // labour_book_dataDataGridView
            // 
            this.labour_book_dataDataGridView.AutoGenerateColumns = false;
            this.labour_book_dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labour_book_dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.labour_book_dataDataGridView.DataSource = this.labour_book_dataBindingSource;
            this.labour_book_dataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labour_book_dataDataGridView.Location = new System.Drawing.Point(0, 25);
            this.labour_book_dataDataGridView.Name = "labour_book_dataDataGridView";
            this.labour_book_dataDataGridView.Size = new System.Drawing.Size(800, 425);
            this.labour_book_dataDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Labour_book";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Labour_book";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number_and_date_of_issue";
            this.dataGridViewTextBoxColumn2.HeaderText = "Number_and_date_of_issue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date_and_number_of_the_enrolment_order";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date_and_number_of_the_enrolment_order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Moving_to_another_unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Moving_to_another_unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_Anket";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_Anket";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormLabourBookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labour_book_dataDataGridView);
            this.Controls.Add(this.labour_book_dataBindingNavigator);
            this.Name = "FormLabourBookData";
            this.Text = "Данные трудовой книжки";
            this.Load += new System.EventHandler(this.FormLabourBookData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataBindingNavigator)).EndInit();
            this.labour_book_dataBindingNavigator.ResumeLayout(false);
            this.labour_book_dataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labour_book_dataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnel_Department_of_the_InstituteDataSet personnel_Department_of_the_InstituteDataSet;
        private System.Windows.Forms.BindingSource labour_book_dataBindingSource;
        private Personnel_Department_of_the_InstituteDataSetTableAdapters.Labour_book_dataTableAdapter labour_book_dataTableAdapter;
        private Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator labour_book_dataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton labour_book_dataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView labour_book_dataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}