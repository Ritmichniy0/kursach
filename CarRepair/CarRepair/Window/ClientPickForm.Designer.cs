namespace CarRepair.Window
{
    partial class ClientPickForm
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.YeapBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownWidth = 444;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(17, 16);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(591, 24);
            this.ComboBox.TabIndex = 0;
            // 
            // YeapBtn
            // 
            this.YeapBtn.Location = new System.Drawing.Point(401, 78);
            this.YeapBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YeapBtn.Name = "YeapBtn";
            this.YeapBtn.Size = new System.Drawing.Size(100, 28);
            this.YeapBtn.TabIndex = 1;
            this.YeapBtn.Text = "ОК";
            this.YeapBtn.UseVisualStyleBackColor = true;
            this.YeapBtn.Click += new System.EventHandler(this.YeapBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(509, 78);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 28);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Отмена";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClientPickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 133);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.YeapBtn);
            this.Controls.Add(this.ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientPickForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор клиента";
            this.Load += new System.EventHandler(this.ClientPickForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button YeapBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}