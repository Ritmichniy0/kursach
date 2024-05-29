namespace CarRepair.Window
{
    partial class Sing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sing));
			this.loginText = new System.Windows.Forms.TextBox();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.singBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginText
			// 
			this.loginText.Location = new System.Drawing.Point(82, 28);
			this.loginText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loginText.Name = "loginText";
			this.loginText.Size = new System.Drawing.Size(180, 20);
			this.loginText.TabIndex = 0;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(82, 85);
			this.passwordText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(180, 20);
			this.passwordText.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 88);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль";
			// 
			// singBtn
			// 
			this.singBtn.Location = new System.Drawing.Point(32, 125);
			this.singBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.singBtn.Name = "singBtn";
			this.singBtn.Size = new System.Drawing.Size(230, 19);
			this.singBtn.TabIndex = 4;
			this.singBtn.Text = "Вход";
			this.singBtn.UseVisualStyleBackColor = true;
			this.singBtn.Click += new System.EventHandler(this.singBtn_Click);
			// 
			// Sing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 172);
			this.Controls.Add(this.singBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.loginText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Sing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sing_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button singBtn;
    }
}