namespace CarRepair.Window
{
    partial class CarPickForm
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
            this.CarBox = new System.Windows.Forms.ComboBox();
            this.YeapBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarBox
            // 
            this.CarBox.FormattingEnabled = true;
            this.CarBox.Location = new System.Drawing.Point(12, 12);
            this.CarBox.Name = "CarBox";
            this.CarBox.Size = new System.Drawing.Size(383, 21);
            this.CarBox.TabIndex = 1;
            // 
            // YeapBtn
            // 
            this.YeapBtn.Location = new System.Drawing.Point(239, 59);
            this.YeapBtn.Name = "YeapBtn";
            this.YeapBtn.Size = new System.Drawing.Size(75, 23);
            this.YeapBtn.TabIndex = 2;
            this.YeapBtn.Text = "ОК";
            this.YeapBtn.UseVisualStyleBackColor = true;
            this.YeapBtn.Click += new System.EventHandler(this.YeapBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(320, 59);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Отмена";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CarPickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 94);
            this.Controls.Add(this.YeapBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CarBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CarPickForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор автомобиля";
            this.Load += new System.EventHandler(this.CarPickForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CarBox;
        private System.Windows.Forms.Button YeapBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}