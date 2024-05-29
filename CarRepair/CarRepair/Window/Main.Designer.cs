namespace CarRepair.Window
{
    partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.LabelName = new System.Windows.Forms.Label();
			this.AddBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.деталиЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пометитьКакВыполненныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
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
			this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.dataGridView.Location = new System.Drawing.Point(12, 31);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(984, 524);
			this.dataGridView.TabIndex = 56;
			this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деталиЗаказаToolStripMenuItem,
            this.пометитьКакВыполненныйToolStripMenuItem,
            this.чекToolStripMenuItem,
            this.удалитьToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(236, 108);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(435, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 20);
			this.label1.TabIndex = 57;
			this.label1.Text = "Текущие ремонты";
			// 
			// LabelName
			// 
			this.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelName.AutoSize = true;
			this.LabelName.BackColor = System.Drawing.SystemColors.Control;
			this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelName.ForeColor = System.Drawing.Color.Black;
			this.LabelName.Location = new System.Drawing.Point(737, 51);
			this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LabelName.Name = "LabelName";
			this.LabelName.Size = new System.Drawing.Size(0, 13);
			this.LabelName.TabIndex = 60;
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddBtn.Image = global::CarRepair.Properties.Resources.Добавить;
			this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddBtn.Location = new System.Drawing.Point(552, 560);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(219, 28);
			this.AddBtn.TabIndex = 58;
			this.AddBtn.Text = "Новый заказ";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EditBtn.Image = global::CarRepair.Properties.Resources.Изменить;
			this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EditBtn.Location = new System.Drawing.Point(777, 560);
			this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(219, 28);
			this.EditBtn.TabIndex = 58;
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// деталиЗаказаToolStripMenuItem
			// 
			this.деталиЗаказаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.деталиЗаказаToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Детали_заказа;
			this.деталиЗаказаToolStripMenuItem.Name = "деталиЗаказаToolStripMenuItem";
			this.деталиЗаказаToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.деталиЗаказаToolStripMenuItem.Text = "Детали заказа";
			this.деталиЗаказаToolStripMenuItem.Click += new System.EventHandler(this.деталиЗаказаToolStripMenuItem_Click);
			// 
			// пометитьКакВыполненныйToolStripMenuItem
			// 
			this.пометитьКакВыполненныйToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Выполненный;
			this.пометитьКакВыполненныйToolStripMenuItem.Name = "пометитьКакВыполненныйToolStripMenuItem";
			this.пометитьКакВыполненныйToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.пометитьКакВыполненныйToolStripMenuItem.Text = "Пометить как выполненный";
			this.пометитьКакВыполненныйToolStripMenuItem.Click += new System.EventHandler(this.пометитьКакВыполненныйToolStripMenuItem_Click);
			// 
			// чекToolStripMenuItem
			// 
			this.чекToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Добавить_автомобиль;
			this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
			this.чекToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.чекToolStripMenuItem.Text = "Чек";
			this.чекToolStripMenuItem.Click += new System.EventHandler(this.чекToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Image = global::CarRepair.Properties.Resources.Удалить;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1008, 593);
			this.Controls.Add(this.LabelName);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ремонт";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem деталиЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пометитьКакВыполненныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
	}
}

