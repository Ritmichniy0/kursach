namespace CarRepair.Window
{
	partial class SpecialisationForm
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label = new System.Windows.Forms.Label();
			this.TitleText = new System.Windows.Forms.TextBox();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.departmentsBox = new System.Windows.Forms.ComboBox();
			this.priceText = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priceText)).BeginInit();
			this.SuspendLayout();
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
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(483, 447);
			this.dataGridView.TabIndex = 42;
			this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			// 
			// label
			// 
			this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(550, 54);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(132, 13);
			this.label.TabIndex = 43;
			this.label.Text = "Название спецализации";
			// 
			// TitleText
			// 
			this.TitleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleText.Location = new System.Drawing.Point(513, 70);
			this.TitleText.MaxLength = 50;
			this.TitleText.Name = "TitleText";
			this.TitleText.Size = new System.Drawing.Size(199, 20);
			this.TitleText.TabIndex = 44;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveBtn.BackColor = System.Drawing.Color.AliceBlue;
			this.SaveBtn.Image = global::CarRepair.Properties.Resources.Сохранить;
			this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveBtn.Location = new System.Drawing.Point(513, 179);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(200, 30);
			this.SaveBtn.TabIndex = 45;
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditBtn.BackColor = System.Drawing.Color.AliceBlue;
			this.EditBtn.Image = global::CarRepair.Properties.Resources.Изменить;
			this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EditBtn.Location = new System.Drawing.Point(616, 143);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(97, 30);
			this.EditBtn.TabIndex = 46;
			this.EditBtn.Text = "Изменить";
			this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Image = global::CarRepair.Properties.Resources.Добавить;
			this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddBtn.Location = new System.Drawing.Point(513, 143);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(97, 30);
			this.AddBtn.TabIndex = 47;
			this.AddBtn.Text = "Добавить";
			this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(565, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Название отдела";
			// 
			// departmentsBox
			// 
			this.departmentsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.departmentsBox.Enabled = false;
			this.departmentsBox.FormattingEnabled = true;
			this.departmentsBox.Location = new System.Drawing.Point(513, 28);
			this.departmentsBox.Name = "departmentsBox";
			this.departmentsBox.Size = new System.Drawing.Size(199, 21);
			this.departmentsBox.TabIndex = 49;
			// 
			// priceText
			// 
			this.priceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.priceText.DecimalPlaces = 2;
			this.priceText.Location = new System.Drawing.Point(514, 117);
			this.priceText.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.priceText.Name = "priceText";
			this.priceText.Size = new System.Drawing.Size(198, 20);
			this.priceText.TabIndex = 80;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(546, 99);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 13);
			this.label4.TabIndex = 81;
			this.label4.Text = "Стоимость работы (руб.)";
			// 
			// SpecialisationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(731, 471);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.priceText);
			this.Controls.Add(this.departmentsBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.TitleText);
			this.Controls.Add(this.label);
			this.Controls.Add(this.dataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SpecialisationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список спецализаций";
			this.Load += new System.EventHandler(this.SpecialisationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priceText)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox TitleText;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox departmentsBox;
		private System.Windows.Forms.NumericUpDown priceText;
		private System.Windows.Forms.Label label4;
	}
}