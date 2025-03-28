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
    public partial class FrmIntroduction : Form
    {
        public FrmIntroduction()
        {
            InitializeComponent();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            FrmTeacherLogin frm = new FrmTeacherLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            FrmStudentLogin frm = new FrmStudentLogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
