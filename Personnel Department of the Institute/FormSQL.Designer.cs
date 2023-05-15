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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFirst = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExample = new System.Windows.Forms.DataGridView();
            this.radioButtonLabour = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonContract = new System.Windows.Forms.RadioButton();
            this.radioButtonAnketa = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageFirst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExample)).BeginInit();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxFSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFirst);
            this.tabControl1.Controls.Add(this.tabPageSelect);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFirst
            // 
            this.tabPageFirst.Controls.Add(this.groupBox1);
            this.tabPageFirst.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirst.Name = "tabPageFirst";
            this.tabPageFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirst.Size = new System.Drawing.Size(792, 424);
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
            this.groupBox1.Size = new System.Drawing.Size(786, 418);
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
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полня запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
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
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(6, 27);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(117, 13);
            this.labelWorker.TabIndex = 0;
            this.labelWorker.Text = "Фамилия сотрудника";
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(166, 24);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(201, 20);
            this.textBoxWorker.TabIndex = 1;
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
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(166, 63);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(201, 20);
            this.textBoxMore.TabIndex = 4;
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
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(4, 200);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 226);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSQL";
            this.Text = "FormSQL";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFirst.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExample)).EndInit();
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
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
    }
}