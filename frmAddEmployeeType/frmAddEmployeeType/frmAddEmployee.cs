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
    public partial class frmAddEmployee : Form
    {
        SPEntities3 db = new SPEntities3();
        public frmAddEmployee()
        {
            InitializeComponent();
            userBindingSource.DataSource = db.Users.ToList();
            titleBindingSource.DataSource = db.Titles.ToList();
            employeeTypeBindingSource.DataSource = db.Employee_Type.ToList();
        }
       
        bool correct = false;
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            correct = true;
            Employee emp = new Employee();

            if (txtEName.Text == ""||txtAccountNum.Text== "" || txtContactNumber.Text == ""||txtEmailAddress.Text == "" || txtESurname.Text == "" || txtID.Text == "" || cbxEmployeeType.SelectedItem=="" )
            {

                MessageBox.Show("Please Enter all fields on the employee Form");
                correct = false;
            }

            if (correct == true)
            {
                emp.Employee_Id = 0;
                emp.Employee_Name = txtEName.Text;
                emp.Employee_Surname = txtESurname.Text;
                emp.Employee_Address = txtAddress.Text;
                emp.Employee_Id_Number = Convert.ToDecimal(txtID.Text);
                emp.Employee_Account_Number =Convert.ToDecimal( txtContactNumber.Text);
                emp.Employee_Name = txtEName.Text;
                //Employee_Type et = cbxEmployeeType.SelectedValue as Employee_Type;
                emp.Employee_Type_ID = Convert.ToInt32(cbxEmployeeType.SelectedValue);
                emp.Employee_Cellphone_Number = txtContactNumber.Text;
                emp.Employee_Email_Address = txtEmailAddress.Text;
                emp.Employee_Tax_Number = txtTaxumber.Text;
                //User us = cbxUser.SelectedValue as User;
                emp.Users_Id = Convert.ToInt32(cbxUser.SelectedValue);
                //Title title = cbxTitle.SelectedValue as Title;
                emp.Title_Id = Convert.ToInt32(cbxTitle.SelectedValue);
            }

            db.Employees.Add(emp);
            db.SaveChanges();
            MessageBox.Show("Employee Added Successfully");
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTaxumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
