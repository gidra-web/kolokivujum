using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Studenti : Form
    {
   
        private readonly StudentBuisness studentBuisness;

        public Studenti()
        {
            this.studentBuisness = new StudentBuisness();
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        //dovuce studente iz baze i ubaci u list box
        private void RefreshData()
        {
            listBoxStudent.Items.Clear();
            List<Student> students = this.studentBuisness.getAllStudents();
            listBoxStudent.Items.Clear();
            foreach(Student student in students)
            {
                listBoxStudent.Items.Add(student.Id+" ("+student.InexNumber+ ") - " + student.AverageMark);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name= textBoxName.Text;
            s.InexNumber=textBoxIndexNumber.Text;
            s.AverageMark=Convert.ToDecimal(textBoxAverageMark.Text);
            //p.ExpireDate = dtp_expireDate.Value;
            //p.ExpireDate = Convert.ToDateTime(tb_expireDate.Text);

            this.studentBuisness.InsertStudent(s);
            RefreshData();
            textBoxName.Text = "";
            textBoxIndexNumber.Text = "";
            textBoxAverageMark.Text = "";
            //dtp_expireDate.Value = DateTime.Now;
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
