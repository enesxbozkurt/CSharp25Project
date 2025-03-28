using Student_Granding_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Granding_System
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }

        public static int stuId = 0;


        GrandingSystemEntities db=new GrandingSystemEntities();

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            var student=db.Lessons.Where(x=>x.StuCitizenshipNumber==txtCitizenshipNumber.Text).FirstOrDefault();
           
            if (student!=null)
            {
                if (student.StuNumber==txtStudentNumber.Text)
                {
                    stuId = db.Lessons.Where(x => x.StuCitizenshipNumber == txtCitizenshipNumber.Text).Select(x=>x.StuId).FirstOrDefault();
                    FrmStudentDashboard frm= new FrmStudentDashboard();
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

        private void FrmStudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
