using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAddEmployeeType
{
    public partial class Form1 : Form
    {
        string option;
        public Form1(string x)
        {
            option = x;
            InitializeComponent();
        }
        
        SPEntities3 db = new SPEntities3();
        bool correct = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            correct = true;
            Employee_Type EmT = new Employee_Type();

            if (rtxtDescription.Text == "")
            {

                MessageBox.Show("Please Enter Employee type details");
                correct = false;
            }

            if (txtEmployeeType.Text == "")
            {

                MessageBox.Show("Please Enter Employee type details");
                correct = false;
            }
            if (correct == true)
            {
                EmT.Employees_Type_Description = rtxtDescription.Text;
                EmT.Employees_Type1 = txtEmployeeType.Text;


                db.Employee_Type.Add(EmT);

                db.SaveChanges();

                MessageBox.Show("Employee Type Added Successfully");
                this.Close();


            }
        }

        private void btnMaintain_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
