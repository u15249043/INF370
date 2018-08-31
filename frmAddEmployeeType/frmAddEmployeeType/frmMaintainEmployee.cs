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
    public partial class frmMaintainEmployee : Form
    {
        int tempID;
        public frmMaintainEmployee(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        SPEntities3 db = new SPEntities3();
        private void frmMaintainEmployee_Load(object sender, EventArgs e)
        {
            var query = db.Employees.Where(co => co.Employee_Id == tempID).FirstOrDefault();

            txtEName.Text = query.Employee_Name.ToString();
            //txtEmployeeTypes.Text = query.Employees_Type1;

            query.Employee_Id = 0;
            //emp.Employee_Name = txtEName.Text;
            txtESurname.Text= query.Employee_Surname;
            txtAddress.Text= query.Employee_Address;
            txtID.Text = Convert.ToString(query.Employee_Id_Number);
           
            txtContactNumber.Text= Convert.ToString(query.Employee_Account_Number);
            txtEName.Text= query.Employee_Name;
            //Employee_Type et = cbxEmployeeType.SelectedValue as Employee_Type;
             cbxEmployeeType.SelectedValue= Convert.ToString(query.Employee_Type_ID);
             txtContactNumber.Text=query.Employee_Cellphone_Number;
             txtEmailAddress.Text= query.Employee_Email_Address;
             txtTaxumber.Text= query.Employee_Tax_Number;
            //User us = cbxUser.SelectedValue as User;
             cbxUser.SelectedValue= Convert.ToString(query.Users_Id);
            //Title title = cbxTitle.SelectedValue as Title;
             cbxTitle.SelectedValue= Convert.ToString(query.Title_Id);
        }
        bool correct = false;
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            correct = true;

            if (txtEName.Text == "" || txtAccountNum.Text == "" || txtContactNumber.Text == "" || txtEmailAddress.Text == "" || txtESurname.Text == "" || txtID.Text == "" || cbxEmployeeType.SelectedItem == "")
            {

                MessageBox.Show("Please Enter all fields on the employee Form");
                correct = false;
            }


            if (correct == true)
            {
                var query = db.Employees.Where(co => co.Employee_Id == tempID).FirstOrDefault();
                query.Employee_Id = 0;
                query.Employee_Name = txtEName.Text;
                query.Employee_Surname = txtESurname.Text;
                query.Employee_Address = txtAddress.Text;
                query.Employee_Id_Number = Convert.ToDecimal(txtID.Text);
                query.Employee_Account_Number = Convert.ToDecimal(txtContactNumber.Text);
                query.Employee_Name = txtEName.Text;
                //Employee_Type et = cbxEmployeeType.SelectedValue as Employee_Type;
                query.Employee_Type_ID = Convert.ToInt32(cbxEmployeeType.SelectedValue);
                query.Employee_Cellphone_Number = txtContactNumber.Text;
                query.Employee_Email_Address = txtEmailAddress.Text;
                query.Employee_Tax_Number = txtTaxumber.Text;
                //User us = cbxUser.SelectedValue as User;
                query.Users_Id = Convert.ToInt32(cbxUser.SelectedValue);
                //Title title = cbxTitle.SelectedValue as Title;
                query.Title_Id = Convert.ToInt32(cbxTitle.SelectedValue);
            }

           
            db.SaveChanges();
            MessageBox.Show("Employee Successfully Deleted");
            this.Close();
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Employee ?", "Delete Employee ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Employee Emt2 = new Employee();
                    Emt2 = db.Employees.Find(tempID);

                    db.Employees.Remove(Emt2);
                    db.SaveChanges();

                    int id = Emt2.Employee_Id;
                    string employee_Value = Convert.ToString(Emt2);
                    MessageBox.Show("Employee Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Employee was not deleted");

                }
            }
        }
    }
}
