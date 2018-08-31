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
    public partial class frmEmployeeTypeM : Form
    {
        int tempID;

        public frmEmployeeTypeM(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        
        SPEntities3 db = new SPEntities3();
        bool correct = false;
        private void btnUpdateET_Click(object sender, EventArgs e)
        {

            correct = true;

            if (txtEmployeeTypeDesc.Text == "")
            {

                MessageBox.Show("Please Enter an Employee Type Description");
                correct = false;
            }

            if (txtEmployeeTypes.Text == "")
            {

                MessageBox.Show("Please Enter emloyee type Text");
                correct = false;
            }
            if (correct == true)
            {

                var query = db.Employee_Type.Where(co => co.Employee_Type_ID == tempID).FirstOrDefault();

                query.Employees_Type_Description = txtEmployeeTypeDesc.Text;
                query.Employees_Type1 = txtEmployeeTypes.Text;
                db.SaveChanges();

                MessageBox.Show("Employee Type Successfully Updated");
                this.Close();
            }
        }

        private void btnDeleteET_Click_1(object sender, EventArgs e)
        {
            
                DialogResult dialogResult = MessageBox.Show("Would you like to delete this Employee Type?", "Delete Employee Type", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        Employee_Type Emt2 = new Employee_Type();
                        Emt2 = db.Employee_Type.Find(tempID);

                        db.Employee_Type.Remove(Emt2);
                        db.SaveChanges();

                        int Marketing = Emt2.Employee_Type_ID;
                        string Marketing_Template_Value = Convert.ToString(Emt2);
                        MessageBox.Show("Employee Type Successfully Deleted");
                        this.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: Employee Type was not deleted");

                    }
                }
            
        }

        private void frmEmployeeTypeM_Load_1(object sender, EventArgs e)
        {
            var query = db.Employee_Type.Where(co => co.Employee_Type_ID == tempID).FirstOrDefault();

            txtEmployeeTypeDesc.Text = query.Employees_Type_Description;
            txtEmployeeTypes.Text = query.Employees_Type1;
        }
    }
}
