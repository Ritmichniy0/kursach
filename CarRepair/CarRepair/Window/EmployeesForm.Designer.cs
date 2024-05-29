namespace CarRepair.Window
{
    partial class EmployeesForm
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
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.nameText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.departmentBox = new System.Windows.Forms.ComboBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.roleBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.loginText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.specialisationBox = new System.Windows.Forms.ComboBox();
			this.secondName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.firstNameText = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.emailTexttBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox.Location = new System.Drawing.Point(953, 155);
			this.maskedTextBox.Mask = "+7(999) 000-00-00";
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(203, 20);
			this.maskedTextBox.TabIndex = 62;
			this.maskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
			// 
			// nameText
			// 
			this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameText.Location = new System.Drawing.Point(953, 72);
			this.nameText.MaxLength = 30;
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(203, 20);
			this.nameText.TabIndex = 58;
			this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1025, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 56;
			this.label1.Text = "Тел. номер";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1038, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 57;
			this.label2.Text = "Имя";
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.dataGridView.Location = new System.Drawing.Point(16, 14);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(920, 589);
			this.dataGridView.TabIndex = 55;
			this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(129, 70);
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Добавить;
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// изменитьToolStripMenuItem
			// 
			this.изменитьToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Изменить;
			this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
			this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.изменитьToolStripMenuItem.Text = "Изменить";
			this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Удалить;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// SaveBtn
			// 
			this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveBtn.Image = global::CarRepair.Properties.Resources.Сохранить;
			this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveBtn.Location = new System.Drawing.Point(953, 465);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(203, 30);
			this.SaveBtn.TabIndex = 59;
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditBtn.Image = global::CarRepair.Properties.Resources.Изменить;
			this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EditBtn.Location = new System.Drawing.Point(1061, 429);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(95, 30);
			this.EditBtn.TabIndex = 60;
			this.EditBtn.Text = "Изменить";
			this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1035, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 56;
			this.label3.Text = "Отдел";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1009, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 56;
			this.label4.Text = "Специализация";
			// 
			// departmentBox
			// 
			this.departmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.departmentBox.FormattingEnabled = true;
			this.departmentBox.Location = new System.Drawing.Point(953, 235);
			this.departmentBox.Name = "departmentBox";
			this.departmentBox.Size = new System.Drawing.Size(203, 21);
			this.departmentBox.TabIndex = 63;
			this.departmentBox.TextChanged += new System.EventHandler(this.DepartmentBox_TextChanged);
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Image = global::CarRepair.Properties.Resources.Добавить;
			this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddBtn.Location = new System.Drawing.Point(953, 429);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(102, 30);
			this.AddBtn.TabIndex = 61;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// roleBox
			// 
			this.roleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.roleBox.FormattingEnabled = true;
			this.roleBox.Location = new System.Drawing.Point(953, 312);
			this.roleBox.Name = "roleBox";
			this.roleBox.Size = new System.Drawing.Size(203, 21);
			this.roleBox.TabIndex = 64;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1038, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 65;
			this.label5.Text = "Роль";
			// 
			// passwordText
			// 
			this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordText.Location = new System.Drawing.Point(953, 391);
			this.passwordText.MaxLength = 50;
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(203, 20);
			this.passwordText.TabIndex = 66;
			// 
			// loginText
			// 
			this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginText.Location = new System.Drawing.Point(953, 352);
			this.loginText.MaxLength = 50;
			this.loginText.Name = "loginText";
			this.loginText.Size = new System.Drawing.Size(203, 20);
			this.loginText.TabIndex = 67;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(1033, 375);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 68;
			this.label6.Text = "Пароль";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1035, 336);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 69;
			this.label7.Text = "Логин";
			// 
			// specialisationBox
			// 
			this.specialisationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.specialisationBox.FormattingEnabled = true;
			this.specialisationBox.Location = new System.Drawing.Point(953, 272);
			this.specialisationBox.Name = "specialisationBox";
			this.specialisationBox.Size = new System.Drawing.Size(203, 21);
			this.specialisationBox.TabIndex = 70;
			// 
			// secondName
			// 
			this.secondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.secondName.Location = new System.Drawing.Point(953, 114);
			this.secondName.MaxLength = 20;
			this.secondName.Name = "secondName";
			this.secondName.Size = new System.Drawing.Size(203, 20);
			this.secondName.TabIndex = 72;
			this.secondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(1029, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 71;
			this.label8.Text = "Отчество";
			// 
			// firstNameText
			// 
			this.firstNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameText.Location = new System.Drawing.Point(953, 35);
			this.firstNameText.MaxLength = 20;
			this.firstNameText.Name = "firstNameText";
			this.firstNameText.Size = new System.Drawing.Size(203, 20);
			this.firstNameText.TabIndex = 74;
			this.firstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(1026, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 13);
			this.label9.TabIndex = 73;
			this.label9.Text = "Фамилия";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1033, 178);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 76;
			this.label10.Text = "Почта";
			// 
			// emailTexttBox
			// 
			this.emailTexttBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTexttBox.Location = new System.Drawing.Point(953, 194);
			this.emailTexttBox.Name = "emailTexttBox";
			this.emailTexttBox.Size = new System.Drawing.Size(203, 20);
			this.emailTexttBox.TabIndex = 77;
			this.emailTexttBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTexttBox_Validating);
			// 
			// EmployeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1168, 613);
			this.Controls.Add(this.emailTexttBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.firstNameText);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.secondName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.specialisationBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.loginText);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.roleBox);
			this.Controls.Add(this.departmentBox);
			this.Controls.Add(this.maskedTextBox);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EmployeesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Сотрудники";
			this.Load += new System.EventHandler(this.EmployeesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox specialisationBox;
		private System.Windows.Forms.TextBox secondName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox firstNameText;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox emailTexttBox;
	}
}