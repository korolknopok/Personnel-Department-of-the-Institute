namespace Personnel_Department_of_the_Institute
{
    partial class FormSQL
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFirst = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExample = new System.Windows.Forms.DataGridView();
            this.radioButtonLabour = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonContract = new System.Windows.Forms.RadioButton();
            this.radioButtonAnketa = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.textBoxdepartment = new System.Windows.Forms.TextBox();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.labeldepartment = new System.Windows.Forms.Label();
            this.labelDegree = new System.Windows.Forms.Label();
            this.textBoxIdAnketa = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewDish = new System.Windows.Forms.DataGridView();
            this.textBoxWeight_dish = new System.Windows.Forms.TextBox();
            this.textBoxPrice_dish = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelEd_dish = new System.Windows.Forms.Label();
            this.labelWeight_dish = new System.Windows.Forms.Label();
            this.labelPrice_dish = new System.Windows.Forms.Label();
            this.textBoxType_dish = new System.Windows.Forms.TextBox();
            this.textBoxName_dish = new System.Windows.Forms.TextBox();
            this.labelType_dish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.panelDish = new System.Windows.Forms.Panel();
            this.textBoxId_dish = new System.Windows.Forms.TextBox();
            this.labelId_dish = new System.Windows.Forms.Label();
            this.radioButtonDelete_dish = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_dish = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert_dish = new System.Windows.Forms.RadioButton();
            this.personnel_Department_of_the_InstituteDataSet = new Personnel_Department_of_the_Institute.Personnel_Department_of_the_InstituteDataSet();
            this.personnelDepartmentoftheInstituteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageFirst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExample)).BeginInit();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            this.groupBoxDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDepartmentoftheInstituteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFirst);
            this.tabControl1.Controls.Add(this.tabPageSelect);
            this.tabControl1.Controls.Add(this.tabPageSubquery);
            this.tabControl1.Controls.Add(this.tabPageDML);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFirst
            // 
            this.tabPageFirst.Controls.Add(this.groupBox1);
            this.tabPageFirst.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirst.Name = "tabPageFirst";
            this.tabPageFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirst.Size = new System.Drawing.Size(792, 537);
            this.tabPageFirst.TabIndex = 0;
            this.tabPageFirst.Text = "Пример запросов";
            this.tabPageFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewExample);
            this.groupBox1.Controls.Add(this.radioButtonLabour);
            this.groupBox1.Controls.Add(this.radioButtonTeacher);
            this.groupBox1.Controls.Add(this.radioButtonContract);
            this.groupBox1.Controls.Add(this.radioButtonAnketa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запросы по данным ";
            // 
            // dataGridViewExample
            // 
            this.dataGridViewExample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExample.Location = new System.Drawing.Point(3, 99);
            this.dataGridViewExample.Name = "dataGridViewExample";
            this.dataGridViewExample.Size = new System.Drawing.Size(786, 319);
            this.dataGridViewExample.TabIndex = 4;
            // 
            // radioButtonLabour
            // 
            this.radioButtonLabour.AutoSize = true;
            this.radioButtonLabour.Location = new System.Drawing.Point(411, 29);
            this.radioButtonLabour.Name = "radioButtonLabour";
            this.radioButtonLabour.Size = new System.Drawing.Size(156, 17);
            this.radioButtonLabour.TabIndex = 3;
            this.radioButtonLabour.TabStop = true;
            this.radioButtonLabour.Text = "Данные трудовой книжки";
            this.radioButtonLabour.UseVisualStyleBackColor = true;
            this.radioButtonLabour.CheckedChanged += new System.EventHandler(this.radioButtonLabour_CheckedChanged);
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Location = new System.Drawing.Point(231, 29);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(147, 17);
            this.radioButtonTeacher.TabIndex = 2;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "Информация о учителях";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            this.radioButtonTeacher.CheckedChanged += new System.EventHandler(this.radioButtonTeacher_CheckedChanged);
            // 
            // radioButtonContract
            // 
            this.radioButtonContract.AutoSize = true;
            this.radioButtonContract.Location = new System.Drawing.Point(128, 29);
            this.radioButtonContract.Name = "radioButtonContract";
            this.radioButtonContract.Size = new System.Drawing.Size(72, 17);
            this.radioButtonContract.TabIndex = 1;
            this.radioButtonContract.TabStop = true;
            this.radioButtonContract.Text = "Контракт";
            this.radioButtonContract.UseVisualStyleBackColor = true;
            this.radioButtonContract.CheckedChanged += new System.EventHandler(this.radioButtonContract_CheckedChanged);
            // 
            // radioButtonAnketa
            // 
            this.radioButtonAnketa.AutoSize = true;
            this.radioButtonAnketa.Location = new System.Drawing.Point(31, 29);
            this.radioButtonAnketa.Name = "radioButtonAnketa";
            this.radioButtonAnketa.Size = new System.Drawing.Size(61, 17);
            this.radioButtonAnketa.TabIndex = 0;
            this.radioButtonAnketa.TabStop = true;
            this.radioButtonAnketa.Text = "Анкета";
            this.radioButtonAnketa.UseVisualStyleBackColor = true;
            this.radioButtonAnketa.CheckedChanged += new System.EventHandler(this.radioButtonAnketa_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 537);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полня запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(4, 200);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 226);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.textBoxWorker);
            this.groupBoxFSelect.Controls.Add(this.labelWorker);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 197);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль сотрудников";
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(257, 168);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(195, 23);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Нагрузка сотрудников";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 116);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(254, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию нагрузки";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(166, 63);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(201, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 65);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(151, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать нагрузку более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(166, 24);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(201, 20);
            this.textBoxWorker.TabIndex = 1;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(6, 27);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(117, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Фамилия сотрудника";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 537);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(2, 160);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(789, 268);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.labelNumber);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 161);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(258, 118);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(151, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(129, 77);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(280, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(7, 80);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(58, 13);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Пед. стаж";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(221, 31);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(188, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(6, 31);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(175, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.textBoxdepartment);
            this.tabPageDML.Controls.Add(this.textBoxDegree);
            this.tabPageDML.Controls.Add(this.labeldepartment);
            this.tabPageDML.Controls.Add(this.labelDegree);
            this.tabPageDML.Controls.Add(this.textBoxIdAnketa);
            this.tabPageDML.Controls.Add(this.labelId);
            this.tabPageDML.Controls.Add(this.dataGridViewDish);
            this.tabPageDML.Controls.Add(this.textBoxWeight_dish);
            this.tabPageDML.Controls.Add(this.textBoxPrice_dish);
            this.tabPageDML.Controls.Add(this.textBoxType);
            this.tabPageDML.Controls.Add(this.labelEd_dish);
            this.tabPageDML.Controls.Add(this.labelWeight_dish);
            this.tabPageDML.Controls.Add(this.labelPrice_dish);
            this.tabPageDML.Controls.Add(this.textBoxType_dish);
            this.tabPageDML.Controls.Add(this.textBoxName_dish);
            this.tabPageDML.Controls.Add(this.labelType_dish);
            this.tabPageDML.Controls.Add(this.label1);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 537);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = " Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // textBoxdepartment
            // 
            this.textBoxdepartment.Location = new System.Drawing.Point(620, 182);
            this.textBoxdepartment.Name = "textBoxdepartment";
            this.textBoxdepartment.Size = new System.Drawing.Size(100, 20);
            this.textBoxdepartment.TabIndex = 18;
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Location = new System.Drawing.Point(620, 135);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDegree.TabIndex = 17;
            // 
            // labeldepartment
            // 
            this.labeldepartment.AutoSize = true;
            this.labeldepartment.Location = new System.Drawing.Point(495, 182);
            this.labeldepartment.Name = "labeldepartment";
            this.labeldepartment.Size = new System.Drawing.Size(52, 13);
            this.labeldepartment.TabIndex = 16;
            this.labeldepartment.Text = "Кафедра";
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(492, 135);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(85, 13);
            this.labelDegree.TabIndex = 15;
            this.labelDegree.Text = "Специальность";
            // 
            // textBoxIdAnketa
            // 
            this.textBoxIdAnketa.Location = new System.Drawing.Point(162, 328);
            this.textBoxIdAnketa.Name = "textBoxIdAnketa";
            this.textBoxIdAnketa.Size = new System.Drawing.Size(166, 20);
            this.textBoxIdAnketa.TabIndex = 14;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(15, 328);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(50, 13);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Id_Anket";
            // 
            // dataGridViewDish
            // 
            this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDish.Location = new System.Drawing.Point(9, 368);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.Size = new System.Drawing.Size(783, 169);
            this.dataGridViewDish.TabIndex = 11;
            // 
            // textBoxWeight_dish
            // 
            this.textBoxWeight_dish.Location = new System.Drawing.Point(162, 286);
            this.textBoxWeight_dish.Name = "textBoxWeight_dish";
            this.textBoxWeight_dish.Size = new System.Drawing.Size(166, 20);
            this.textBoxWeight_dish.TabIndex = 10;
            // 
            // textBoxPrice_dish
            // 
            this.textBoxPrice_dish.Location = new System.Drawing.Point(162, 249);
            this.textBoxPrice_dish.Name = "textBoxPrice_dish";
            this.textBoxPrice_dish.Size = new System.Drawing.Size(166, 20);
            this.textBoxPrice_dish.TabIndex = 9;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(162, 209);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(166, 20);
            this.textBoxType.TabIndex = 8;
            // 
            // labelEd_dish
            // 
            this.labelEd_dish.AutoSize = true;
            this.labelEd_dish.Location = new System.Drawing.Point(12, 286);
            this.labelEd_dish.Name = "labelEd_dish";
            this.labelEd_dish.Size = new System.Drawing.Size(121, 13);
            this.labelEd_dish.TabIndex = 7;
            this.labelEd_dish.Text = "Дата конца контракта";
            // 
            // labelWeight_dish
            // 
            this.labelWeight_dish.AutoSize = true;
            this.labelWeight_dish.Location = new System.Drawing.Point(12, 249);
            this.labelWeight_dish.Name = "labelWeight_dish";
            this.labelWeight_dish.Size = new System.Drawing.Size(126, 13);
            this.labelWeight_dish.TabIndex = 6;
            this.labelWeight_dish.Text = "Дата начала контракта";
            // 
            // labelPrice_dish
            // 
            this.labelPrice_dish.AutoSize = true;
            this.labelPrice_dish.Location = new System.Drawing.Point(12, 209);
            this.labelPrice_dish.Name = "labelPrice_dish";
            this.labelPrice_dish.Size = new System.Drawing.Size(55, 13);
            this.labelPrice_dish.TabIndex = 5;
            this.labelPrice_dish.Text = "Нагрузка";
            // 
            // textBoxType_dish
            // 
            this.textBoxType_dish.Location = new System.Drawing.Point(162, 167);
            this.textBoxType_dish.Name = "textBoxType_dish";
            this.textBoxType_dish.Size = new System.Drawing.Size(166, 20);
            this.textBoxType_dish.TabIndex = 4;
            // 
            // textBoxName_dish
            // 
            this.textBoxName_dish.Location = new System.Drawing.Point(162, 129);
            this.textBoxName_dish.Name = "textBoxName_dish";
            this.textBoxName_dish.Size = new System.Drawing.Size(166, 20);
            this.textBoxName_dish.TabIndex = 3;
            // 
            // labelType_dish
            // 
            this.labelType_dish.AutoSize = true;
            this.labelType_dish.Location = new System.Drawing.Point(12, 167);
            this.labelType_dish.Name = "labelType_dish";
            this.labelType_dish.Size = new System.Drawing.Size(89, 13);
            this.labelType_dish.TabIndex = 2;
            this.labelType_dish.Text = "Лист дисциплин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Педогогический стаж";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonFind);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.panelDish);
            this.groupBoxDML.Controls.Add(this.textBoxId_dish);
            this.groupBoxDML.Controls.Add(this.labelId_dish);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_dish);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_dish);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_dish);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 113);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(324, 56);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(92, 23);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(478, 53);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(173, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // panelDish
            // 
            this.panelDish.Location = new System.Drawing.Point(0, 110);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(789, 311);
            this.panelDish.TabIndex = 1;
            // 
            // textBoxId_dish
            // 
            this.textBoxId_dish.Location = new System.Drawing.Point(103, 60);
            this.textBoxId_dish.Name = "textBoxId_dish";
            this.textBoxId_dish.Size = new System.Drawing.Size(200, 20);
            this.textBoxId_dish.TabIndex = 4;
            // 
            // labelId_dish
            // 
            this.labelId_dish.AutoSize = true;
            this.labelId_dish.Location = new System.Drawing.Point(6, 63);
            this.labelId_dish.Name = "labelId_dish";
            this.labelId_dish.Size = new System.Drawing.Size(81, 13);
            this.labelId_dish.TabIndex = 3;
            this.labelId_dish.Text = "Код контракта\r\n";
            // 
            // radioButtonDelete_dish
            // 
            this.radioButtonDelete_dish.AutoSize = true;
            this.radioButtonDelete_dish.Location = new System.Drawing.Point(478, 19);
            this.radioButtonDelete_dish.Name = "radioButtonDelete_dish";
            this.radioButtonDelete_dish.Size = new System.Drawing.Size(280, 17);
            this.radioButtonDelete_dish.TabIndex = 2;
            this.radioButtonDelete_dish.TabStop = true;
            this.radioButtonDelete_dish.Text = "Удалить данные по контракту с заданным кодом.";
            this.radioButtonDelete_dish.UseVisualStyleBackColor = true;
            this.radioButtonDelete_dish.CheckedChanged += new System.EventHandler(this.radioButtonDelete_dish_CheckedChanged);
            // 
            // radioButtonUpdate_dish
            // 
            this.radioButtonUpdate_dish.AutoSize = true;
            this.radioButtonUpdate_dish.Location = new System.Drawing.Point(192, 19);
            this.radioButtonUpdate_dish.Name = "radioButtonUpdate_dish";
            this.radioButtonUpdate_dish.Size = new System.Drawing.Size(285, 17);
            this.radioButtonUpdate_dish.TabIndex = 1;
            this.radioButtonUpdate_dish.TabStop = true;
            this.radioButtonUpdate_dish.Text = "Изменить данные по контракту с заданным кодом";
            this.radioButtonUpdate_dish.UseVisualStyleBackColor = true;
            this.radioButtonUpdate_dish.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_dish_CheckedChanged);
            // 
            // radioButtonInsert_dish
            // 
            this.radioButtonInsert_dish.AutoSize = true;
            this.radioButtonInsert_dish.Location = new System.Drawing.Point(6, 20);
            this.radioButtonInsert_dish.Name = "radioButtonInsert_dish";
            this.radioButtonInsert_dish.Size = new System.Drawing.Size(185, 17);
            this.radioButtonInsert_dish.TabIndex = 0;
            this.radioButtonInsert_dish.TabStop = true;
            this.radioButtonInsert_dish.Text = "Добавить данные по контракту\r\n";
            this.radioButtonInsert_dish.UseVisualStyleBackColor = true;
            this.radioButtonInsert_dish.CheckedChanged += new System.EventHandler(this.radioButtonInsert_dish_CheckedChanged);
            // 
            // personnel_Department_of_the_InstituteDataSet
            // 
            this.personnel_Department_of_the_InstituteDataSet.DataSetName = "Personnel_Department_of_the_InstituteDataSet";
            this.personnel_Department_of_the_InstituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnelDepartmentoftheInstituteDataSetBindingSource
            // 
            this.personnelDepartmentoftheInstituteDataSetBindingSource.DataSource = this.personnel_Department_of_the_InstituteDataSet;
            this.personnelDepartmentoftheInstituteDataSetBindingSource.Position = 0;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFirst.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExample)).EndInit();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.tabPageDML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnel_Department_of_the_InstituteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDepartmentoftheInstituteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFirst;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewExample;
        private System.Windows.Forms.RadioButton radioButtonLabour;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.RadioButton radioButtonContract;
        private System.Windows.Forms.RadioButton radioButtonAnketa;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.TextBox textBoxType_dish;
        private System.Windows.Forms.TextBox textBoxName_dish;
        private System.Windows.Forms.Label labelType_dish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Panel panelDish;
        private System.Windows.Forms.TextBox textBoxId_dish;
        private System.Windows.Forms.Label labelId_dish;
        private System.Windows.Forms.RadioButton radioButtonDelete_dish;
        private System.Windows.Forms.RadioButton radioButtonUpdate_dish;
        private System.Windows.Forms.RadioButton radioButtonInsert_dish;
        private System.Windows.Forms.DataGridView dataGridViewDish;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxWeight_dish;
        private System.Windows.Forms.TextBox textBoxPrice_dish;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelEd_dish;
        private System.Windows.Forms.Label labelWeight_dish;
        private System.Windows.Forms.Label labelPrice_dish;
        private System.Windows.Forms.TextBox textBoxIdAnketa;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxdepartment;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.Label labeldepartment;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.BindingSource personnelDepartmentoftheInstituteDataSetBindingSource;
        private Personnel_Department_of_the_InstituteDataSet personnel_Department_of_the_InstituteDataSet;
    }
}