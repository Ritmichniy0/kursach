namespace CarRepair.Window
{
	partial class DashBoardForm
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelMenuReporting = new System.Windows.Forms.Panel();
			this.ScheduleEmployeeBtn = new System.Windows.Forms.Button();
			this.ScheduleAllEmployeesBtn = new System.Windows.Forms.Button();
			this.ScheduleYearsBtn = new System.Windows.Forms.Button();
			this.ScheduleMonthsBtn = new System.Windows.Forms.Button();
			this.OrderHistoryPeriodbtn = new System.Windows.Forms.Button();
			this.HistoryCarBtn = new System.Windows.Forms.Button();
			this.HistoryClientBtn = new System.Windows.Forms.Button();
			this.ReportingBtn = new System.Windows.Forms.Button();
			this.panelMenuDirectory = new System.Windows.Forms.Panel();
			this.EmployeeBtn = new System.Windows.Forms.Button();
			this.Clientbtn = new System.Windows.Forms.Button();
			this.CarBtn = new System.Windows.Forms.Button();
			this.DetailBtn = new System.Windows.Forms.Button();
			this.DepartmentBtn = new System.Windows.Forms.Button();
			this.DirectoryBtn = new System.Windows.Forms.Button();
			this.RepairBtn = new System.Windows.Forms.Button();
			this.StatisticBtn = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.LabelRole = new System.Windows.Forms.Label();
			this.WindowLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelName = new System.Windows.Forms.Label();
			this.SettingBtn = new System.Windows.Forms.Button();
			this.panelExitMenu = new System.Windows.Forms.Panel();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelMenuReporting.SuspendLayout();
			this.panelMenuDirectory.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelExitMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panelMenu.Controls.Add(this.panelMenuReporting);
			this.panelMenu.Controls.Add(this.ReportingBtn);
			this.panelMenu.Controls.Add(this.panelMenuDirectory);
			this.panelMenu.Controls.Add(this.DirectoryBtn);
			this.panelMenu.Controls.Add(this.RepairBtn);
			this.panelMenu.Controls.Add(this.StatisticBtn);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(258, 656);
			this.panelMenu.TabIndex = 0;
			// 
			// panelMenuReporting
			// 
			this.panelMenuReporting.Controls.Add(this.ScheduleEmployeeBtn);
			this.panelMenuReporting.Controls.Add(this.ScheduleAllEmployeesBtn);
			this.panelMenuReporting.Controls.Add(this.ScheduleYearsBtn);
			this.panelMenuReporting.Controls.Add(this.ScheduleMonthsBtn);
			this.panelMenuReporting.Controls.Add(this.OrderHistoryPeriodbtn);
			this.panelMenuReporting.Controls.Add(this.HistoryCarBtn);
			this.panelMenuReporting.Controls.Add(this.HistoryClientBtn);
			this.panelMenuReporting.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMenuReporting.Location = new System.Drawing.Point(0, 423);
			this.panelMenuReporting.Name = "panelMenuReporting";
			this.panelMenuReporting.Size = new System.Drawing.Size(258, 208);
			this.panelMenuReporting.TabIndex = 6;
			this.panelMenuReporting.Visible = false;
			// 
			// ScheduleEmployeeBtn
			// 
			this.ScheduleEmployeeBtn.BackColor = System.Drawing.Color.LightGray;
			this.ScheduleEmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.ScheduleEmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ScheduleEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ScheduleEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScheduleEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ScheduleEmployeeBtn.Image = global::CarRepair.Properties.Resources.Сотрудники;
			this.ScheduleEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ScheduleEmployeeBtn.Location = new System.Drawing.Point(0, 180);
			this.ScheduleEmployeeBtn.Name = "ScheduleEmployeeBtn";
			this.ScheduleEmployeeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.ScheduleEmployeeBtn.Size = new System.Drawing.Size(258, 30);
			this.ScheduleEmployeeBtn.TabIndex = 9;
			this.ScheduleEmployeeBtn.Text = "График по сотруднику";
			this.ScheduleEmployeeBtn.UseVisualStyleBackColor = false;
			this.ScheduleEmployeeBtn.Click += new System.EventHandler(this.ScheduleEmployeeBtn_Click);
			// 
			// ScheduleAllEmployeesBtn
			// 
			this.ScheduleAllEmployeesBtn.BackColor = System.Drawing.Color.LightGray;
			this.ScheduleAllEmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.ScheduleAllEmployeesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ScheduleAllEmployeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ScheduleAllEmployeesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScheduleAllEmployeesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ScheduleAllEmployeesBtn.Image = global::CarRepair.Properties.Resources.Клиенты;
			this.ScheduleAllEmployeesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ScheduleAllEmployeesBtn.Location = new System.Drawing.Point(0, 150);
			this.ScheduleAllEmployeesBtn.Name = "ScheduleAllEmployeesBtn";
			this.ScheduleAllEmployeesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.ScheduleAllEmployeesBtn.Size = new System.Drawing.Size(258, 30);
			this.ScheduleAllEmployeesBtn.TabIndex = 8;
			this.ScheduleAllEmployeesBtn.Text = "График по всем сотрудникамм";
			this.ScheduleAllEmployeesBtn.UseVisualStyleBackColor = false;
			this.ScheduleAllEmployeesBtn.Click += new System.EventHandler(this.ScheduleAllEmployeesBtn_Click);
			// 
			// ScheduleYearsBtn
			// 
			this.ScheduleYearsBtn.BackColor = System.Drawing.Color.LightGray;
			this.ScheduleYearsBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.ScheduleYearsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ScheduleYearsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ScheduleYearsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScheduleYearsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ScheduleYearsBtn.Image = global::CarRepair.Properties.Resources.Календарь;
			this.ScheduleYearsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ScheduleYearsBtn.Location = new System.Drawing.Point(0, 120);
			this.ScheduleYearsBtn.Name = "ScheduleYearsBtn";
			this.ScheduleYearsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.ScheduleYearsBtn.Size = new System.Drawing.Size(258, 30);
			this.ScheduleYearsBtn.TabIndex = 7;
			this.ScheduleYearsBtn.Text = "График по годам";
			this.ScheduleYearsBtn.UseVisualStyleBackColor = false;
			this.ScheduleYearsBtn.Click += new System.EventHandler(this.ScheduleYearsBtn_Click);
			// 
			// ScheduleMonthsBtn
			// 
			this.ScheduleMonthsBtn.BackColor = System.Drawing.Color.LightGray;
			this.ScheduleMonthsBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.ScheduleMonthsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ScheduleMonthsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ScheduleMonthsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScheduleMonthsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ScheduleMonthsBtn.Image = global::CarRepair.Properties.Resources.Календарь;
			this.ScheduleMonthsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ScheduleMonthsBtn.Location = new System.Drawing.Point(0, 90);
			this.ScheduleMonthsBtn.Name = "ScheduleMonthsBtn";
			this.ScheduleMonthsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.ScheduleMonthsBtn.Size = new System.Drawing.Size(258, 30);
			this.ScheduleMonthsBtn.TabIndex = 6;
			this.ScheduleMonthsBtn.Text = "График по месяцам";
			this.ScheduleMonthsBtn.UseVisualStyleBackColor = false;
			this.ScheduleMonthsBtn.Click += new System.EventHandler(this.ScheduleMonthsBtn_Click);
			// 
			// OrderHistoryPeriodbtn
			// 
			this.OrderHistoryPeriodbtn.BackColor = System.Drawing.Color.LightGray;
			this.OrderHistoryPeriodbtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.OrderHistoryPeriodbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.OrderHistoryPeriodbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OrderHistoryPeriodbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OrderHistoryPeriodbtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OrderHistoryPeriodbtn.Image = global::CarRepair.Properties.Resources.История_заказов_за_период;
			this.OrderHistoryPeriodbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.OrderHistoryPeriodbtn.Location = new System.Drawing.Point(0, 60);
			this.OrderHistoryPeriodbtn.Name = "OrderHistoryPeriodbtn";
			this.OrderHistoryPeriodbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.OrderHistoryPeriodbtn.Size = new System.Drawing.Size(258, 30);
			this.OrderHistoryPeriodbtn.TabIndex = 5;
			this.OrderHistoryPeriodbtn.Text = "История заказов за период";
			this.OrderHistoryPeriodbtn.UseVisualStyleBackColor = false;
			this.OrderHistoryPeriodbtn.Click += new System.EventHandler(this.OrderHistoryPeriodbtn_Click);
			// 
			// HistoryCarBtn
			// 
			this.HistoryCarBtn.BackColor = System.Drawing.Color.LightGray;
			this.HistoryCarBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.HistoryCarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.HistoryCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.HistoryCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HistoryCarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HistoryCarBtn.Image = global::CarRepair.Properties.Resources.История_по_автомобилю;
			this.HistoryCarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.HistoryCarBtn.Location = new System.Drawing.Point(0, 30);
			this.HistoryCarBtn.Name = "HistoryCarBtn";
			this.HistoryCarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.HistoryCarBtn.Size = new System.Drawing.Size(258, 30);
			this.HistoryCarBtn.TabIndex = 4;
			this.HistoryCarBtn.Text = "История по автомобилю";
			this.HistoryCarBtn.UseVisualStyleBackColor = false;
			this.HistoryCarBtn.Click += new System.EventHandler(this.HistoryCarBtn_Click);
			// 
			// HistoryClientBtn
			// 
			this.HistoryClientBtn.BackColor = System.Drawing.Color.LightGray;
			this.HistoryClientBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.HistoryClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.HistoryClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.HistoryClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HistoryClientBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HistoryClientBtn.Image = global::CarRepair.Properties.Resources.История_по_клиенту;
			this.HistoryClientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.HistoryClientBtn.Location = new System.Drawing.Point(0, 0);
			this.HistoryClientBtn.Name = "HistoryClientBtn";
			this.HistoryClientBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.HistoryClientBtn.Size = new System.Drawing.Size(258, 30);
			this.HistoryClientBtn.TabIndex = 3;
			this.HistoryClientBtn.Text = "Ремонт по клиенту";
			this.HistoryClientBtn.UseVisualStyleBackColor = false;
			this.HistoryClientBtn.Click += new System.EventHandler(this.HistoryClientBtn_Click);
			// 
			// ReportingBtn
			// 
			this.ReportingBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.ReportingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.ReportingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ReportingBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ReportingBtn.Image = global::CarRepair.Properties.Resources.Отчетность;
			this.ReportingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ReportingBtn.Location = new System.Drawing.Point(0, 371);
			this.ReportingBtn.Name = "ReportingBtn";
			this.ReportingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.ReportingBtn.Size = new System.Drawing.Size(258, 52);
			this.ReportingBtn.TabIndex = 5;
			this.ReportingBtn.Text = "Отчетность";
			this.ReportingBtn.UseVisualStyleBackColor = true;
			this.ReportingBtn.Click += new System.EventHandler(this.ReportingBtn_Click);
			// 
			// panelMenuDirectory
			// 
			this.panelMenuDirectory.Controls.Add(this.EmployeeBtn);
			this.panelMenuDirectory.Controls.Add(this.Clientbtn);
			this.panelMenuDirectory.Controls.Add(this.CarBtn);
			this.panelMenuDirectory.Controls.Add(this.DetailBtn);
			this.panelMenuDirectory.Controls.Add(this.DepartmentBtn);
			this.panelMenuDirectory.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMenuDirectory.Location = new System.Drawing.Point(0, 221);
			this.panelMenuDirectory.Name = "panelMenuDirectory";
			this.panelMenuDirectory.Size = new System.Drawing.Size(258, 150);
			this.panelMenuDirectory.TabIndex = 4;
			this.panelMenuDirectory.Visible = false;
			// 
			// EmployeeBtn
			// 
			this.EmployeeBtn.BackColor = System.Drawing.Color.LightGray;
			this.EmployeeBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.EmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.EmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EmployeeBtn.Image = global::CarRepair.Properties.Resources.Сотрудники;
			this.EmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.EmployeeBtn.Location = new System.Drawing.Point(0, 120);
			this.EmployeeBtn.Name = "EmployeeBtn";
			this.EmployeeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.EmployeeBtn.Size = new System.Drawing.Size(258, 30);
			this.EmployeeBtn.TabIndex = 7;
			this.EmployeeBtn.Text = "Сотрудники";
			this.EmployeeBtn.UseVisualStyleBackColor = false;
			this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
			// 
			// Clientbtn
			// 
			this.Clientbtn.BackColor = System.Drawing.Color.LightGray;
			this.Clientbtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.Clientbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Clientbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clientbtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Clientbtn.Image = global::CarRepair.Properties.Resources.Клиенты;
			this.Clientbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Clientbtn.Location = new System.Drawing.Point(0, 90);
			this.Clientbtn.Name = "Clientbtn";
			this.Clientbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.Clientbtn.Size = new System.Drawing.Size(258, 30);
			this.Clientbtn.TabIndex = 6;
			this.Clientbtn.Text = "Клиенты";
			this.Clientbtn.UseVisualStyleBackColor = false;
			this.Clientbtn.Click += new System.EventHandler(this.Clientbtn_Click);
			// 
			// CarBtn
			// 
			this.CarBtn.BackColor = System.Drawing.Color.LightGray;
			this.CarBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.CarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.CarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CarBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CarBtn.Image = global::CarRepair.Properties.Resources.Марка_автомобилей;
			this.CarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CarBtn.Location = new System.Drawing.Point(0, 60);
			this.CarBtn.Name = "CarBtn";
			this.CarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.CarBtn.Size = new System.Drawing.Size(258, 30);
			this.CarBtn.TabIndex = 5;
			this.CarBtn.Text = "Марка автомобиля ";
			this.CarBtn.UseVisualStyleBackColor = false;
			this.CarBtn.Click += new System.EventHandler(this.CarBtn_Click);
			// 
			// DetailBtn
			// 
			this.DetailBtn.BackColor = System.Drawing.Color.LightGray;
			this.DetailBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.DetailBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.DetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DetailBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DetailBtn.Image = global::CarRepair.Properties.Resources.Запчасти;
			this.DetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DetailBtn.Location = new System.Drawing.Point(0, 30);
			this.DetailBtn.Name = "DetailBtn";
			this.DetailBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.DetailBtn.Size = new System.Drawing.Size(258, 30);
			this.DetailBtn.TabIndex = 4;
			this.DetailBtn.Text = "Детали";
			this.DetailBtn.UseVisualStyleBackColor = false;
			this.DetailBtn.Click += new System.EventHandler(this.DetailBtn_Click);
			// 
			// DepartmentBtn
			// 
			this.DepartmentBtn.BackColor = System.Drawing.Color.LightGray;
			this.DepartmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.DepartmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.DepartmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DepartmentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DepartmentBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DepartmentBtn.Image = global::CarRepair.Properties.Resources.Отдел;
			this.DepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DepartmentBtn.Location = new System.Drawing.Point(0, 0);
			this.DepartmentBtn.Name = "DepartmentBtn";
			this.DepartmentBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.DepartmentBtn.Size = new System.Drawing.Size(258, 30);
			this.DepartmentBtn.TabIndex = 3;
			this.DepartmentBtn.Text = "Отделы";
			this.DepartmentBtn.UseVisualStyleBackColor = false;
			this.DepartmentBtn.Click += new System.EventHandler(this.DepartmentBtn_Click);
			// 
			// DirectoryBtn
			// 
			this.DirectoryBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.DirectoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.DirectoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DirectoryBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.DirectoryBtn.Image = global::CarRepair.Properties.Resources.Справочники;
			this.DirectoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DirectoryBtn.Location = new System.Drawing.Point(0, 169);
			this.DirectoryBtn.Name = "DirectoryBtn";
			this.DirectoryBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.DirectoryBtn.Size = new System.Drawing.Size(258, 52);
			this.DirectoryBtn.TabIndex = 3;
			this.DirectoryBtn.Text = "Справочники";
			this.DirectoryBtn.UseVisualStyleBackColor = true;
			this.DirectoryBtn.Click += new System.EventHandler(this.DirectoryBtn_Click);
			// 
			// RepairBtn
			// 
			this.RepairBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.RepairBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.RepairBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RepairBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RepairBtn.Image = global::CarRepair.Properties.Resources.Ремонт;
			this.RepairBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RepairBtn.Location = new System.Drawing.Point(0, 117);
			this.RepairBtn.Name = "RepairBtn";
			this.RepairBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.RepairBtn.Size = new System.Drawing.Size(258, 52);
			this.RepairBtn.TabIndex = 2;
			this.RepairBtn.Text = "Ремонт";
			this.RepairBtn.UseVisualStyleBackColor = true;
			this.RepairBtn.Click += new System.EventHandler(this.RepairBtn_Click);
			// 
			// StatisticBtn
			// 
			this.StatisticBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.StatisticBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.StatisticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StatisticBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.StatisticBtn.Image = global::CarRepair.Properties.Resources.История_отделов;
			this.StatisticBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.StatisticBtn.Location = new System.Drawing.Point(0, 65);
			this.StatisticBtn.Name = "StatisticBtn";
			this.StatisticBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.StatisticBtn.Size = new System.Drawing.Size(258, 52);
			this.StatisticBtn.TabIndex = 1;
			this.StatisticBtn.Text = "Статистика";
			this.StatisticBtn.UseVisualStyleBackColor = true;
			this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.Teal;
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(258, 65);
			this.panelLogo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Linen;
			this.label1.Location = new System.Drawing.Point(39, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ritmichniy";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(258, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(796, 65);
			this.panel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.LabelRole, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.WindowLabel, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 32);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// LabelRole
			// 
			this.LabelRole.AutoSize = true;
			this.LabelRole.Dock = System.Windows.Forms.DockStyle.Top;
			this.LabelRole.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelRole.ForeColor = System.Drawing.SystemColors.Control;
			this.LabelRole.Location = new System.Drawing.Point(3, 0);
			this.LabelRole.Name = "LabelRole";
			this.LabelRole.Size = new System.Drawing.Size(392, 21);
			this.LabelRole.TabIndex = 0;
			this.LabelRole.Text = "Роль : ";
			// 
			// WindowLabel
			// 
			this.WindowLabel.AutoSize = true;
			this.WindowLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WindowLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.WindowLabel.Location = new System.Drawing.Point(401, 5);
			this.WindowLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.WindowLabel.Name = "WindowLabel";
			this.WindowLabel.Size = new System.Drawing.Size(0, 22);
			this.WindowLabel.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.34673F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84925F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.67839F));
			this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SettingBtn, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelExitMenu, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 33);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.ForeColor = System.Drawing.SystemColors.Control;
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(546, 21);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Пользователь : ";
			// 
			// SettingBtn
			// 
			this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.SettingBtn.Image = global::CarRepair.Properties.Resources.Программа;
			this.SettingBtn.Location = new System.Drawing.Point(711, 1);
			this.SettingBtn.Margin = new System.Windows.Forms.Padding(1);
			this.SettingBtn.Name = "SettingBtn";
			this.SettingBtn.Size = new System.Drawing.Size(84, 32);
			this.SettingBtn.TabIndex = 1;
			this.SettingBtn.UseVisualStyleBackColor = true;
			this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
			// 
			// panelExitMenu
			// 
			this.panelExitMenu.Controls.Add(this.ExitBtn);
			this.panelExitMenu.Controls.Add(this.CloseBtn);
			this.panelExitMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelExitMenu.Location = new System.Drawing.Point(555, 3);
			this.panelExitMenu.Name = "panelExitMenu";
			this.panelExitMenu.Size = new System.Drawing.Size(152, 30);
			this.panelExitMenu.TabIndex = 2;
			this.panelExitMenu.Visible = false;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.ExitBtn.Image = global::CarRepair.Properties.Resources.Exit;
			this.ExitBtn.Location = new System.Drawing.Point(2, 0);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 30);
			this.ExitBtn.TabIndex = 1;
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.CloseBtn.Image = global::CarRepair.Properties.Resources.Отмена;
			this.CloseBtn.Location = new System.Drawing.Point(77, 0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 30);
			this.CloseBtn.TabIndex = 0;
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// panelDesktop
			// 
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(258, 65);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(796, 591);
			this.panelDesktop.TabIndex = 2;
			// 
			// DashBoardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 656);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelMenu);
			this.Name = "DashBoardForm";
			this.Text = "Главное окно";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoardForm_FormClosed);
			this.Load += new System.EventHandler(this.DashBoardForm_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelMenuReporting.ResumeLayout(false);
			this.panelMenuDirectory.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelExitMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button StatisticBtn;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button DirectoryBtn;
		private System.Windows.Forms.Button RepairBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.Panel panelMenuDirectory;
		private System.Windows.Forms.Button CarBtn;
		private System.Windows.Forms.Button DetailBtn;
		private System.Windows.Forms.Button DepartmentBtn;
		private System.Windows.Forms.Button Clientbtn;
		private System.Windows.Forms.Panel panelMenuReporting;
		private System.Windows.Forms.Button ScheduleMonthsBtn;
		private System.Windows.Forms.Button OrderHistoryPeriodbtn;
		private System.Windows.Forms.Button HistoryCarBtn;
		private System.Windows.Forms.Button HistoryClientBtn;
		private System.Windows.Forms.Button ScheduleYearsBtn;
		private System.Windows.Forms.Button ScheduleEmployeeBtn;
		private System.Windows.Forms.Button ScheduleAllEmployeesBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label LabelRole;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button SettingBtn;
		private System.Windows.Forms.Panel panelExitMenu;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.Label WindowLabel;
		private System.Windows.Forms.Button ReportingBtn;
		private System.Windows.Forms.Button EmployeeBtn;
	}
}