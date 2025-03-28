namespace Student_Granding_System
{
    partial class FrmIntroduction
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
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.Location = new System.Drawing.Point(69, 89);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(152, 123);
            this.btnTeacherLogin.TabIndex = 0;
            this.btnTeacherLogin.Text = "Teacher Login";
            this.btnTeacherLogin.UseVisualStyleBackColor = true;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.Location = new System.Drawing.Point(256, 89);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(152, 123);
            this.btnStudentLogin.TabIndex = 1;
            this.btnStudentLogin.Text = "Student Login";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // FrmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 353);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.btnTeacherLogin);
            this.Name = "FrmIntroduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIntroduction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.Button btnStudentLogin;
    }
}

