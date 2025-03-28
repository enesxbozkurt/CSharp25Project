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
    public partial class FrmTeacherDashboard : Form
    {
        public FrmTeacherDashboard()
        {
            InitializeComponent();
        }

        GrandingSystemEntities db = new GrandingSystemEntities();


        private void FrmTeacherDashboard_Load(object sender, EventArgs e)
        {
            var values = db.Lessons.ToList();
            dataGridView1.DataSource = values;

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected=dataGridView1.SelectedCells[0].RowIndex;

            txtStudentName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtStudentSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtStudentNumber.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            exam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            exam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            exam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

            decimal e1= decimal.Parse(exam1.Text.ToString());
            decimal e2= decimal.Parse(exam2.Text.ToString());
            decimal e3= decimal.Parse(exam3.Text.ToString());
            decimal avg = (e1+e2+e3)/3;


            lblAverage.Text= avg.ToString();
            //var average = (db.Lessons.Select(x => x.Average).FirstOrDefault());
            //decimal avg=decimal.Parse(average.ToString());

            if (avg >= 50)
            {
                btnSuccessStatus.BackColor = Color.Green;
                btnSuccessStatus.Text ="SUCCESS!";
            }
            else
            {
                btnSuccessStatus.BackColor = Color.Red;
                btnSuccessStatus.Text = "FAİL!";
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            int id =int.Parse(dataGridView1.Rows[selected].Cells[0].Value.ToString());
            string e1 = exam1.Text.ToString();
            string e2 = exam2.Text.ToString();
            string e3 = exam3.Text.ToString();
            var values = db.Lessons.Find(id);
            values.StuE1 = e1;
            values.StuE2 = e2;
            values.StuE3 = e3;
            db.SaveChanges();
            MessageBox.Show("Update is succesfully!");
            var values2=db.Lessons.ToList();
            dataGridView1.DataSource = values2;
        }
    }
}
