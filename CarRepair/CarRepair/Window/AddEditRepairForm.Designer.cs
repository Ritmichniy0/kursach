namespace CarRepair.Window
{
    partial class AddEditRepairForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ClientBox = new System.Windows.Forms.ComboBox();
			this.ClientBtn = new System.Windows.Forms.Button();
			this.CarBox = new System.Windows.Forms.ComboBox();
			this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.repairNoteText = new System.Windows.Forms.TextBox();
			this.departmentBox = new System.Windows.Forms.ComboBox();
			this.employeeBox = new System.Windows.Forms.ComboBox();
			this.AddRepairBtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label9 = new System.Windows.Forms.Label();
			this.totalPriceLabel = new System.Windows.Forms.Label();
			this.YeapBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.CarBtn = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.specialisationBox = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.detailBox = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.countDetailText = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.countDetailText)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(110, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Клиент";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Автомобиль";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(110, 72);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Начало работы";
			// 
			// ClientBox
			// 
			this.ClientBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientBox.DropDownWidth = 435;
			this.ClientBox.FormattingEnabled = true;
			this.ClientBox.Location = new System.Drawing.Point(242, 12);
			this.ClientBox.Name = "ClientBox";
			this.ClientBox.Size = new System.Drawing.Size(314, 21);
			this.ClientBox.TabIndex = 0;
			this.ClientBox.TextChanged += new System.EventHandler(this.ClientBox_TextChanged);
			// 
			// ClientBtn
			// 
			this.ClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ClientBtn.Image = global::CarRepair.Properties.Resources.Добавление_клиента;
			this.ClientBtn.Location = new System.Drawing.Point(562, 10);
			this.ClientBtn.Name = "ClientBtn";
			this.ClientBtn.Size = new System.Drawing.Size(31, 23);
			this.ClientBtn.TabIndex = 63;
			this.ClientBtn.UseVisualStyleBackColor = true;
			this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
			// 
			// CarBox
			// 
			this.CarBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CarBox.DropDownWidth = 435;
			this.CarBox.FormattingEnabled = true;
			this.CarBox.Location = new System.Drawing.Point(242, 39);
			this.CarBox.Name = "CarBox";
			this.CarBox.Size = new System.Drawing.Size(314, 21);
			this.CarBox.TabIndex = 0;
			// 
			// dateTimeBegin
			// 
			this.dateTimeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimeBegin.Location = new System.Drawing.Point(242, 66);
			this.dateTimeBegin.Name = "dateTimeBegin";
			this.dateTimeBegin.Size = new System.Drawing.Size(351, 20);
			this.dateTimeBegin.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(110, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Описание ремонта";
			// 
			// repairNoteText
			// 
			this.repairNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.repairNoteText.Location = new System.Drawing.Point(241, 281);
			this.repairNoteText.MaxLength = 50;
			this.repairNoteText.Name = "repairNoteText";
			this.repairNoteText.Size = new System.Drawing.Size(352, 20);
			this.repairNoteText.TabIndex = 74;
			// 
			// departmentBox
			// 
			this.departmentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.departmentBox.DropDownWidth = 467;
			this.departmentBox.FormattingEnabled = true;
			this.departmentBox.Location = new System.Drawing.Point(242, 97);
			this.departmentBox.Name = "departmentBox";
			this.departmentBox.Size = new System.Drawing.Size(351, 21);
			this.departmentBox.TabIndex = 75;
			this.departmentBox.TextChanged += new System.EventHandler(this.departmentBox_TextChanged);
			// 
			// employeeBox
			// 
			this.employeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeBox.DropDownWidth = 467;
			this.employeeBox.FormattingEnabled = true;
			this.employeeBox.Location = new System.Drawing.Point(242, 168);
			this.employeeBox.Name = "employeeBox";
			this.employeeBox.Size = new System.Drawing.Size(351, 21);
			this.employeeBox.TabIndex = 76;
			// 
			// AddRepairBtn
			// 
			this.AddRepairBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddRepairBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddRepairBtn.Location = new System.Drawing.Point(240, 308);
			this.AddRepairBtn.Name = "AddRepairBtn";
			this.AddRepairBtn.Size = new System.Drawing.Size(248, 29);
			this.AddRepairBtn.TabIndex = 8;
			this.AddRepairBtn.Text = "Добавить деталь к ремонту";
			this.AddRepairBtn.UseVisualStyleBackColor = true;
			this.AddRepairBtn.Click += new System.EventHandler(this.AddRepairBtn_Click);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(110, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Отдел";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(110, 171);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 13);
			this.label8.TabIndex = 80;
			this.label8.Text = "Мастер";
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
			this.dataGridView.Location = new System.Drawing.Point(34, 343);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(639, 251);
			this.dataGridView.TabIndex = 9;
			this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(38, 607);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(151, 13);
			this.label9.TabIndex = 60;
			this.label9.Text = "Общая стоимость ремонита";
			// 
			// totalPriceLabel
			// 
			this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.totalPriceLabel.AutoSize = true;
			this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.totalPriceLabel.Location = new System.Drawing.Point(195, 607);
			this.totalPriceLabel.Name = "totalPriceLabel";
			this.totalPriceLabel.Size = new System.Drawing.Size(76, 13);
			this.totalPriceLabel.TabIndex = 61;
			this.totalPriceLabel.Text = "<%PRICE%>";
			// 
			// YeapBtn
			// 
			this.YeapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.YeapBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.YeapBtn.Location = new System.Drawing.Point(368, 625);
			this.YeapBtn.Name = "YeapBtn";
			this.YeapBtn.Size = new System.Drawing.Size(134, 29);
			this.YeapBtn.TabIndex = 81;
			this.YeapBtn.Text = "Сохранить";
			this.YeapBtn.UseVisualStyleBackColor = true;
			this.YeapBtn.Click += new System.EventHandler(this.YeapBtn_Click);
			// 
			// exitBtn
			// 
			this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exitBtn.Location = new System.Drawing.Point(508, 625);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(163, 29);
			this.exitBtn.TabIndex = 59;
			this.exitBtn.Text = "Отмена/Выход";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// CarBtn
			// 
			this.CarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CarBtn.Image = global::CarRepair.Properties.Resources.Добавить;
			this.CarBtn.Location = new System.Drawing.Point(561, 37);
			this.CarBtn.Name = "CarBtn";
			this.CarBtn.Size = new System.Drawing.Size(32, 23);
			this.CarBtn.TabIndex = 82;
			this.CarBtn.UseVisualStyleBackColor = true;
			this.CarBtn.Click += new System.EventHandler(this.CarBtn_Click);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(110, 135);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 13);
			this.label10.TabIndex = 83;
			this.label10.Text = "Работа";
			// 
			// specialisationBox
			// 
			this.specialisationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.specialisationBox.FormattingEnabled = true;
			this.specialisationBox.Location = new System.Drawing.Point(242, 132);
			this.specialisationBox.Name = "specialisationBox";
			this.specialisationBox.Size = new System.Drawing.Size(351, 21);
			this.specialisationBox.TabIndex = 84;
			this.specialisationBox.TextChanged += new System.EventHandler(this.specialisationBox_TextChanged);
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(110, 208);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 13);
			this.label11.TabIndex = 86;
			this.label11.Text = "Деталь";
			// 
			// detailBox
			// 
			this.detailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.detailBox.DropDownWidth = 467;
			this.detailBox.FormattingEnabled = true;
			this.detailBox.Location = new System.Drawing.Point(242, 205);
			this.detailBox.Name = "detailBox";
			this.detailBox.Size = new System.Drawing.Size(351, 21);
			this.detailBox.TabIndex = 85;
			this.detailBox.SelectedIndexChanged += new System.EventHandler(this.detailBox_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(110, 245);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 13);
			this.label12.TabIndex = 87;
			this.label12.Text = "Кол-во деталей";
			// 
			// countDetailText
			// 
			this.countDetailText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.countDetailText.Location = new System.Drawing.Point(242, 245);
			this.countDetailText.Name = "countDetailText";
			this.countDetailText.Size = new System.Drawing.Size(351, 20);
			this.countDetailText.TabIndex = 88;
			this.countDetailText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// AddEditRepairForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(708, 657);
			this.Controls.Add(this.countDetailText);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.detailBox);
			this.Controls.Add(this.specialisationBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.CarBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.YeapBtn);
			this.Controls.Add(this.totalPriceLabel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.AddRepairBtn);
			this.Controls.Add(this.employeeBox);
			this.Controls.Add(this.departmentBox);
			this.Controls.Add(this.repairNoteText);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimeBegin);
			this.Controls.Add(this.CarBox);
			this.Controls.Add(this.ClientBtn);
			this.Controls.Add(this.ClientBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddEditRepairForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавить ремонт";
			this.Load += new System.EventHandler(this.AddEditRepairForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.countDetailText)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.ComboBox CarBox;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairNoteText;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.Button AddRepairBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button YeapBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button CarBtn;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox specialisationBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox detailBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown countDetailText;
	}
}