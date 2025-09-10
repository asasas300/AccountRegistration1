using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration1
{
    public partial class FrmConfirm : Form
    {
       

        private void FrmConfirm_Load_1(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInfoClass.SetStudentNo.ToString();
            lblName.Text = StudentInfoClass.SetFullName;
            lblProgram.Text = StudentInfoClass.SetProgram;
            lblBirthday.Text = StudentInfoClass.SetBirthday;
            lblGender.Text = StudentInfoClass.SetGender;
            lblContactNo.Text = "+63" + StudentInfoClass.SetContactNo.ToString();
            lblAge.Text = StudentInfoClass.SetAge.ToString();
        }

    

        public FrmConfirm()
        {
            InitializeComponent();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
