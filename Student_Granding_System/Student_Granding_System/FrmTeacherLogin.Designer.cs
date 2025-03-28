namespace Student_Granding_System
{
    partial class FrmTeacherLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeachUsername = new System.Windows.Forms.TextBox();
            this.txtTeachPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeachLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtTeachUsername
            // 
            this.txtTeachUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachUsername.Location = new System.Drawing.Point(166, 40);
            this.txtTeachUsername.Name = "txtTeachUsername";
            this.txtTeachUsername.Size = new System.Drawing.Size(134, 24);
            this.txtTeachUsername.TabIndex = 1;
            // 
            // txtTeachPassword
            // 
            this.txtTeachPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachPassword.Location = new System.Drawing.Point(166, 80);
            this.txtTeachPassword.Name = "txtTeachPassword";
            this.txtTeachPassword.PasswordChar = '*';
            this.txtTeachPassword.Size = new System.Drawing.Size(134, 24);
            this.txtTeachPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btnTeachLogin
            // 
            this.btnTeachLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachLogin.Location = new System.Drawing.Point(166, 121);
            this.btnTeachLogin.Name = "btnTeachLogin";
            this.btnTeachLogin.Size = new System.Drawing.Size(134, 47);
            this.btnTeachLogin.TabIndex = 4;
            this.btnTeachLogin.Text = "Login";
            this.btnTeachLogin.UseVisualStyleBackColor = true;
            this.btnTeachLogin.Click += new System.EventHandler(this.btnTeachLogin_Click);
            // 
            // FrmTeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.btnTeachLogin);
            this.Controls.Add(this.txtTeachPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeachUsername);
            this.Controls.Add(this.label1);
            this.Name = "FrmTeacherLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeacherLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeachUsername;
        private System.Windows.Forms.TextBox txtTeachPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTeachLogin;
    }
}