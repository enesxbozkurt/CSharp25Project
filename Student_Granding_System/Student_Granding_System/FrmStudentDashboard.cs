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
    public partial class FrmStudentDashboard : Form
    {
        public FrmStudentDashboard()
        {
            InitializeComponent();
        }

        GrandingSystemEntities db=new GrandingSystemEntities();

        private void FrmStudentDashboard_Load(object sender, EventArgs e)
        {
            int id = FrmStudentLogin.stuId;
            var values=db.Lessons.Where(x=>x.StuId==id).ToList();
            dataGridViews.DataSource = values;
            int selected = dataGridViews.SelectedCells[0].RowIndex;

            txtStudentName.Text = dataGridViews.Rows[selected].Cells[2].Value.ToString();
            txtStudentSurname.Text = dataGridViews.Rows[selected].Cells[3].Value.ToString();
            txtStudentNumber.Text = dataGridViews.Rows[selected].Cells[1].Value.ToString();
            exam1.Text = dataGridViews.Rows[selected].Cells[4].Value.ToString();
            exam2.Text = dataGridViews.Rows[selected].Cells[5].Value.ToString();
            exam3.Text = dataGridViews.Rows[selected].Cells[6].Value.ToString();

            decimal e1 = decimal.Parse(exam1.Text.ToString());
            decimal e2 = decimal.Parse(exam2.Text.ToString());
            decimal e3 = decimal.Parse(exam3.Text.ToString());
            decimal avg = (e1 + e2 + e3) / 3;


            lblAverage.Text = avg.ToString();
            //var average = (db.Lessons.Select(x => x.Average).FirstOrDefault());
            //decimal avg=decimal.Parse(average.ToString());

            if (avg >= 50)
            {
                btnSuccessStatus.BackColor = Color.Green;
                btnSuccessStatus.Text = "you have successfully passed the class :)";
            }
            else
            {
                btnSuccessStatus.BackColor = Color.Red;
                btnSuccessStatus.Text = "sorry, you failed :(";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
