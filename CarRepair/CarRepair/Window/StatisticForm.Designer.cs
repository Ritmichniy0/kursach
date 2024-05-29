namespace CarRepair.Window
{
	partial class StatisticForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelWorkAll = new System.Windows.Forms.Label();
			this.labelWork = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelWorkNotEnd = new System.Windows.Forms.Label();
			this.chartEmployee = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chartEmployee);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(837, 450);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 100);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.IndianRed;
			this.panel2.Controls.Add(this.labelWorkAll);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(272, 94);
			this.panel2.TabIndex = 0;
			// 
			// labelWorkAll
			// 
			this.labelWorkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelWorkAll.AutoSize = true;
			this.labelWorkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkAll.Location = new System.Drawing.Point(42, 19);
			this.labelWorkAll.Name = "labelWorkAll";
			this.labelWorkAll.Size = new System.Drawing.Size(170, 24);
			this.labelWorkAll.TabIndex = 0;
			this.labelWorkAll.Text = "Всего заказов : ";
			// 
			// labelWork
			// 
			this.labelWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelWork.AutoSize = true;
			this.labelWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWork.Location = new System.Drawing.Point(16, 19);
			this.labelWork.Name = "labelWork";
			this.labelWork.Size = new System.Drawing.Size(249, 24);
			this.labelWork.TabIndex = 0;
			this.labelWork.Text = "Завершенных заказов : ";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkCyan;
			this.panel3.Controls.Add(this.labelWork);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(281, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(273, 94);
			this.panel3.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panel4.Controls.Add(this.labelWorkNotEnd);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(560, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(274, 94);
			this.panel4.TabIndex = 2;
			// 
			// labelWorkNotEnd
			// 
			this.labelWorkNotEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelWorkNotEnd.AutoSize = true;
			this.labelWorkNotEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkNotEnd.Location = new System.Drawing.Point(86, 19);
			this.labelWorkNotEnd.Name = "labelWorkNotEnd";
			this.labelWorkNotEnd.Size = new System.Drawing.Size(117, 24);
			this.labelWorkNotEnd.TabIndex = 0;
			this.labelWorkNotEnd.Text = "В работе : ";
			// 
			// chartEmployee
			// 
			this.chartEmployee.BorderSkin.BackColor = System.Drawing.SystemColors.ControlText;
			chartArea2.Name = "ChartArea1";
			this.chartEmployee.ChartAreas.Add(chartArea2);
			this.chartEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartEmployee.Legends.Add(legend2);
			this.chartEmployee.Location = new System.Drawing.Point(0, 100);
			this.chartEmployee.Name = "chartEmployee";
			this.chartEmployee.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series2.ChartArea = "ChartArea1";
			series2.IsXValueIndexed = true;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartEmployee.Series.Add(series2);
			this.chartEmployee.Size = new System.Drawing.Size(837, 350);
			this.chartEmployee.TabIndex = 1;
			// 
			// StatisticForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 450);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "StatisticForm";
			this.Text = "Статистика";
			this.Load += new System.EventHandler(this.StatisticForm_Load);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartEmployee)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployee;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label labelWorkNotEnd;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelWork;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelWorkAll;
	}
}