namespace Personnel_Department_of_the_Institute
{
    partial class FormAnket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnket));
            System.Windows.Forms.Label id_AnketaLabel;
            System.Windows.Forms.Label specialityLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label surNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label past_place_of_workLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label burn_placeLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label contact_phone_numberLabel;
            this.personnel_Department_of_the_InstituteDataSet = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSet();
            this.anketaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketaTableAdapter = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.AnketaTableAdapter();
            this.tableAdapterManager = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager();
            this.anketaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.anketaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AnketaTextBox = new System.Windows.Forms.TextBox();
            this.specialityTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.past_place_of_workTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.burn_placeTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.contact_phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxStripTool = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTableAdapter = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.ContractTableAdapter();
            this.contractDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_AnketaLabel = new System.Windows.Forms.Label();
            specialityLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            surNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            past_place_of_workLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            burn_placeLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            contact_phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingNavigator)).BeginInit();
            this.anketaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personnel_Department_of_the_InstituteDataSet
            // 
            this.personnel_Department_of_the_InstituteDataSet.DataSetName = "Personnel_Department_of_the_InstituteDataSet";
            this.personnel_Department_of_the_InstituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anketaBindingSource
            // 
            this.anketaBindingSource.DataMember = "Anketa";
            this.anketaBindingSource.DataSource = this.personnel_Department_of_the_InstituteDataSet;
            // 
            // anketaTableAdapter
            // 
            this.anketaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnketaTableAdapter = this.anketaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.Information_about_teachersTableAdapter = null;
            this.tableAdapterManager.Labour_book_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // anketaBindingNavigator
            // 
            this.anketaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.anketaBindingNavigator.BindingSource = this.anketaBindingSource;
            this.anketaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.anketaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.anketaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.anketaBindingNavigatorSaveItem,
            this.TextBoxStripTool,
            this.toolStripButton1});
            this.anketaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.anketaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.anketaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.anketaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.anketaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.anketaBindingNavigator.Name = "anketaBindingNavigator";
            this.anketaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.anketaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.anketaBindingNavigator.TabIndex = 0;
            this.anketaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // anketaBindingNavigatorSaveItem
            // 
            this.anketaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.anketaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("anketaBindingNavigatorSaveItem.Image")));
            this.anketaBindingNavigatorSaveItem.Name = "anketaBindingNavigatorSaveItem";
            this.anketaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.anketaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.anketaBindingNavigatorSaveItem.Click += new System.EventHandler(this.anketaBindingNavigatorSaveItem_Click_1);
            // 
            // id_AnketaLabel
            // 
            id_AnketaLabel.AutoSize = true;
            id_AnketaLabel.Location = new System.Drawing.Point(11, 35);
            id_AnketaLabel.Name = "id_AnketaLabel";
            id_AnketaLabel.Size = new System.Drawing.Size(56, 13);
            id_AnketaLabel.TabIndex = 1;
            id_AnketaLabel.Text = "Id Anketa:";
            // 
            // id_AnketaTextBox
            // 
            this.id_AnketaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Id_Anketa", true));
            this.id_AnketaTextBox.Location = new System.Drawing.Point(135, 32);
            this.id_AnketaTextBox.Name = "id_AnketaTextBox";
            this.id_AnketaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AnketaTextBox.TabIndex = 2;
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.Location = new System.Drawing.Point(11, 61);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new System.Drawing.Size(55, 13);
            specialityLabel.TabIndex = 3;
            specialityLabel.Text = "Speciality:";
            // 
            // specialityTextBox
            // 
            this.specialityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Speciality", true));
            this.specialityTextBox.Location = new System.Drawing.Point(135, 58);
            this.specialityTextBox.Name = "specialityTextBox";
            this.specialityTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialityTextBox.TabIndex = 4;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(11, 87);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(72, 13);
            middleNameLabel.TabIndex = 5;
            middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(135, 84);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 6;
            // 
            // surNameLabel
            // 
            surNameLabel.AutoSize = true;
            surNameLabel.Location = new System.Drawing.Point(11, 113);
            surNameLabel.Name = "surNameLabel";
            surNameLabel.Size = new System.Drawing.Size(57, 13);
            surNameLabel.TabIndex = 7;
            surNameLabel.Text = "Sur Name:";
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "SurName", true));
            this.surNameTextBox.Location = new System.Drawing.Point(135, 110);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surNameTextBox.TabIndex = 8;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(11, 139);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(135, 136);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(11, 165);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(29, 13);
            iNNLabel.TabIndex = 11;
            iNNLabel.Text = "INN:";
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(135, 162);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(100, 20);
            this.iNNTextBox.TabIndex = 12;
            // 
            // past_place_of_workLabel
            // 
            past_place_of_workLabel.AutoSize = true;
            past_place_of_workLabel.Location = new System.Drawing.Point(11, 191);
            past_place_of_workLabel.Name = "past_place_of_workLabel";
            past_place_of_workLabel.Size = new System.Drawing.Size(98, 13);
            past_place_of_workLabel.TabIndex = 13;
            past_place_of_workLabel.Text = "Past place of work:";
            // 
            // past_place_of_workTextBox
            // 
            this.past_place_of_workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Past_place_of_work", true));
            this.past_place_of_workTextBox.Location = new System.Drawing.Point(135, 188);
            this.past_place_of_workTextBox.Name = "past_place_of_workTextBox";
            this.past_place_of_workTextBox.Size = new System.Drawing.Size(100, 20);
            this.past_place_of_workTextBox.TabIndex = 14;
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(11, 217);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(58, 13);
            educationLabel.TabIndex = 15;
            educationLabel.Text = "Education:";
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Education", true));
            this.educationTextBox.Location = new System.Drawing.Point(135, 214);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(100, 20);
            this.educationTextBox.TabIndex = 16;
            // 
            // burn_placeLabel
            // 
            burn_placeLabel.AutoSize = true;
            burn_placeLabel.Location = new System.Drawing.Point(11, 243);
            burn_placeLabel.Name = "burn_placeLabel";
            burn_placeLabel.Size = new System.Drawing.Size(61, 13);
            burn_placeLabel.TabIndex = 17;
            burn_placeLabel.Text = "Burn place:";
            // 
            // burn_placeTextBox
            // 
            this.burn_placeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Burn_place", true));
            this.burn_placeTextBox.Location = new System.Drawing.Point(135, 240);
            this.burn_placeTextBox.Name = "burn_placeTextBox";
            this.burn_placeTextBox.Size = new System.Drawing.Size(100, 20);
            this.burn_placeTextBox.TabIndex = 18;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(11, 269);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 19;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(135, 266);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 20;
            // 
            // contact_phone_numberLabel
            // 
            contact_phone_numberLabel.AutoSize = true;
            contact_phone_numberLabel.Location = new System.Drawing.Point(11, 295);
            contact_phone_numberLabel.Name = "contact_phone_numberLabel";
            contact_phone_numberLabel.Size = new System.Drawing.Size(118, 13);
            contact_phone_numberLabel.TabIndex = 21;
            contact_phone_numberLabel.Text = "Contact phone number:";
            // 
            // contact_phone_numberTextBox
            // 
            this.contact_phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.anketaBindingSource, "Contact_phone_number", true));
            this.contact_phone_numberTextBox.Location = new System.Drawing.Point(135, 292);
            this.contact_phone_numberTextBox.Name = "contact_phone_numberTextBox";
            this.contact_phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.contact_phone_numberTextBox.TabIndex = 22;
            // 
            // TextBoxStripTool
            // 
            this.TextBoxStripTool.Name = "TextBoxStripTool";
            this.TextBoxStripTool.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.personnel_Department_of_the_InstituteDataSet;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // contractDataGridView
            // 
            this.contractDataGridView.AutoGenerateColumns = false;
            this.contractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.contractDataGridView.DataSource = this.contractBindingSource;
            this.contractDataGridView.Location = new System.Drawing.Point(0, 334);
            this.contractDataGridView.Name = "contractDataGridView";
            this.contractDataGridView.Size = new System.Drawing.Size(800, 220);
            this.contractDataGridView.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Contract";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Contract";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pedagogic_stage";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pedagogic_stage";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "List_of_disciplines";
            this.dataGridViewTextBoxColumn3.HeaderText = "List_of_disciplines";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Load_in_the_current_year_number_of_hours";
            this.dataGridViewTextBoxColumn4.HeaderText = "Load_in_the_current_year_number_of_hours";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_of_conclusion_of_the_contract";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date_of_conclusion_of_the_contract";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Contract_end_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contract_end_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_Anketa";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_Anketa";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FormAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.contractDataGridView);
            this.Controls.Add(id_AnketaLabel);
            this.Controls.Add(this.id_AnketaTextBox);
            this.Controls.Add(specialityLabel);
            this.Controls.Add(this.specialityTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(surNameLabel);
            this.Controls.Add(this.surNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(past_place_of_workLabel);
            this.Controls.Add(this.past_place_of_workTextBox);
            this.Controls.Add(educationLabel);
            this.Controls.Add(this.educationTextBox);
            this.Controls.Add(burn_placeLabel);
            this.Controls.Add(this.burn_placeTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(contact_phone_numberLabel);
            this.Controls.Add(this.contact_phone_numberTextBox);
            this.Controls.Add(this.anketaBindingNavigator);
            this.Name = "FormAnket";
            this.Text = "Анкета";
            this.Load += new System.EventHandler(this.FormAnket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingNavigator)).EndInit();
            this.anketaBindingNavigator.ResumeLayout(false);
            this.anketaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personnel_Department_of_the_InstituteDataSet personnel_Department_of_the_InstituteDataSet;
        private System.Windows.Forms.BindingSource anketaBindingSource;
        private Personnel_Department_of_the_InstituteDataSetTableAdapters.AnketaTableAdapter anketaTableAdapter;
        private Personnel_Department_of_the_InstituteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator anketaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton anketaBindingNavigatorSaveItem;
        private Personnel_Department_of_the_InstituteDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.ToolStripComboBox TextBoxStripTool;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox id_AnketaTextBox;
        private System.Windows.Forms.TextBox specialityTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox past_place_of_workTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox burn_placeTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox contact_phone_numberTextBox;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.DataGridView contractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}