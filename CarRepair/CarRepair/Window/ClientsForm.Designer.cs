namespace CarRepair.Window
{
    partial class ClientsForm
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
			this.nameText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ShowCarBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.firstNameText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.secondNameText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.emailTexttBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameText
			// 
			this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameText.Location = new System.Drawing.Point(519, 70);
			this.nameText.MaxLength = 20;
			this.nameText.Name = "nameText";
			this.nameText.Size = new System.Drawing.Size(199, 20);
			this.nameText.TabIndex = 51;
			this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(604, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 49;
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
			this.dataGridView.Size = new System.Drawing.Size(489, 447);
			this.dataGridView.TabIndex = 48;
			this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(129, 48);
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
			// SaveBtn
			// 
			this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveBtn.Image = global::CarRepair.Properties.Resources.Сохранить;
			this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveBtn.Location = new System.Drawing.Point(519, 304);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(199, 30);
			this.SaveBtn.TabIndex = 58;
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditBtn.Image = global::CarRepair.Properties.Resources.Изменить;
			this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EditBtn.Location = new System.Drawing.Point(623, 268);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(95, 30);
			this.EditBtn.TabIndex = 60;
			this.EditBtn.Text = "Изменить";
			this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedTextBox.Location = new System.Drawing.Point(519, 147);
			this.maskedTextBox.Mask = "+7(999) 000-00-00";
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(199, 20);
			this.maskedTextBox.TabIndex = 53;
			this.maskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_KeyDown);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(589, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 49;
			this.label1.Text = "Тел. номер";
			// 
			// ShowCarBtn
			// 
			this.ShowCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowCarBtn.Image = global::CarRepair.Properties.Resources.Детали_заказа;
			this.ShowCarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ShowCarBtn.Location = new System.Drawing.Point(519, 214);
			this.ShowCarBtn.Name = "ShowCarBtn";
			this.ShowCarBtn.Size = new System.Drawing.Size(199, 30);
			this.ShowCarBtn.TabIndex = 55;
			this.ShowCarBtn.Text = "Показать автомобили клиента";
			this.ShowCarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ShowCarBtn.UseVisualStyleBackColor = true;
			this.ShowCarBtn.Click += new System.EventHandler(this.ShowCarBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Image = global::CarRepair.Properties.Resources.Добавить;
			this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddBtn.Location = new System.Drawing.Point(519, 268);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(98, 30);
			this.AddBtn.TabIndex = 61;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// firstNameText
			// 
			this.firstNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameText.Location = new System.Drawing.Point(519, 28);
			this.firstNameText.MaxLength = 25;
			this.firstNameText.Name = "firstNameText";
			this.firstNameText.Size = new System.Drawing.Size(199, 20);
			this.firstNameText.TabIndex = 50;
			this.firstNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(589, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 56;
			this.label3.Text = "Фамилия";
			// 
			// secondNameText
			// 
			this.secondNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.secondNameText.Location = new System.Drawing.Point(519, 109);
			this.secondNameText.MaxLength = 25;
			this.secondNameText.Name = "secondNameText";
			this.secondNameText.Size = new System.Drawing.Size(199, 20);
			this.secondNameText.TabIndex = 52;
			this.secondNameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleText_KeyPress);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(592, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 57;
			this.label4.Text = "Отчество";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(603, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 59;
			this.label5.Text = "Email";
			// 
			// emailTexttBox
			// 
			this.emailTexttBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTexttBox.Location = new System.Drawing.Point(519, 188);
			this.emailTexttBox.MaxLength = 30;
			this.emailTexttBox.Name = "emailTexttBox";
			this.emailTexttBox.Size = new System.Drawing.Size(199, 20);
			this.emailTexttBox.TabIndex = 62;
			this.emailTexttBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTexttBox_Validating);
			// 
			// ClientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(737, 471);
			this.Controls.Add(this.emailTexttBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.secondNameText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.firstNameText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.maskedTextBox);
			this.Controls.Add(this.ShowCarBtn);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.nameText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ClientsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Клиенты";
			this.Load += new System.EventHandler(this.ClientsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowCarBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
		private System.Windows.Forms.TextBox firstNameText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox secondNameText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox emailTexttBox;
	}
}