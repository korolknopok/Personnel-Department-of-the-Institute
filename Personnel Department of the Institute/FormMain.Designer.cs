namespace Personnel_Department_of_the_Institute
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.AboutTheProgram = new System.Windows.Forms.ToolStripButton();
            this.Anketa = new System.Windows.Forms.ToolStripButton();
            this.Contract = new System.Windows.Forms.ToolStripButton();
            this.InformationButton = new System.Windows.Forms.ToolStripButton();
            this.LabourBookButton = new System.Windows.Forms.ToolStripButton();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.AboutTheProgramToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton,
            this.AboutTheProgram,
            this.Anketa,
            this.Contract,
            this.InformationButton,
            this.LabourBookButton});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 24);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(800, 25);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "ToolStrip";
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitButton.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.logout__1_;
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(23, 22);
            this.ExitButton.Text = "toolStripButton1";
            this.ExitButton.ToolTipText = "Закрыть программу!\r\n";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutTheProgram
            // 
            this.AboutTheProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutTheProgram.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_warning_sign_80795;
            this.AboutTheProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutTheProgram.Name = "AboutTheProgram";
            this.AboutTheProgram.Size = new System.Drawing.Size(23, 22);
            this.AboutTheProgram.Text = "toolStripButton1";
            this.AboutTheProgram.ToolTipText = "О программе";
            this.AboutTheProgram.Click += new System.EventHandler(this.AboutTheProgram_Click);
            // 
            // Anketa
            // 
            this.Anketa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Anketa.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_review_5362828;
            this.Anketa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Anketa.Name = "Anketa";
            this.Anketa.Size = new System.Drawing.Size(23, 22);
            this.Anketa.Text = "AnketaButton";
            this.Anketa.Click += new System.EventHandler(this.Anketa_Click);
            // 
            // Contract
            // 
            this.Contract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Contract.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_contract_with_pen_85030;
            this.Contract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(23, 22);
            this.Contract.Text = "ContractButton";
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InformationButton.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_info_943933;
            this.InformationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(23, 22);
            this.InformationButton.Text = "InformationButton";
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // LabourBookButton
            // 
            this.LabourBookButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LabourBookButton.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_book_4347419;
            this.LabourBookButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LabourBookButton.Name = "LabourBookButton";
            this.LabourBookButton.Size = new System.Drawing.Size(23, 22);
            this.LabourBookButton.Text = "LabourBookButton";
            this.LabourBookButton.Click += new System.EventHandler(this.LabourBookButton_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.logout__1_;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutTheProgramToolStripMenuItem
            // 
            this.AboutTheProgramToolStripMenuItem.Image = global::Personnel_Department_of_the_Institute.Properties.Resources.free_icon_warning_sign_80795;
            this.AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem";
            this.AboutTheProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.AboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.AboutTheProgramToolStripMenuItem.Text = "About the program";
            this.AboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "FormMain";
            this.Text = "Программа для отдела кадров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripButton AboutTheProgram;
        private System.Windows.Forms.ToolStripButton Anketa;
        private System.Windows.Forms.ToolStripButton Contract;
        private System.Windows.Forms.ToolStripButton InformationButton;
        private System.Windows.Forms.ToolStripButton LabourBookButton;
    }
}

