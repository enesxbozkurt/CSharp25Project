using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Student_Granding_System.Models;

namespace Student_Granding_System
{
    public partial class FrmTeacherLogin : Form
    {
        public FrmTeacherLogin()
        {
            InitializeComponent();
        }

        GrandingSystemEntities db= new GrandingSystemEntities();

        SqlConnection conn = new SqlConnection("Data Source=SL11B97077\\SQLEXPRESS03; Initial Catalog=GrandingSystem;Integrated Security=True");

        private void btnTeachLogin_Click(object sender, EventArgs e)
        {
            
            var teacher=db.Teachers.Where(x=>x.TeachUsername==txtTeachUsername.Text).FirstOrDefault();
            if (teacher!=null)
            {
                if (teacher.TeachPassword==txtTeachPassword.Text)
                {
                    FrmTeacherDashboard frm = new FrmTeacherDashboard();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı şifre! Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı! Lütfen tekrar deneyiniz.");
            }

        }
    }
}
