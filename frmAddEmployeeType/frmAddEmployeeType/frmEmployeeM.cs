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
    public partial class frmEmployeeM : Form
    {
        SPEntities3 db = new SPEntities3();

        public frmEmployeeM()
        {
            InitializeComponent();

        }

        private void frmEmployeeM_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = db.Employees.ToList();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            frmMaintainEmployee mEmployee = new frmMaintainEmployee(0);
            mEmployee.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchEmployee.Text != "")
            {

                List<Employee> Etype = db.Employees.Where(o => o.Employee_Name.Contains(txtSearchEmployee.Text)).ToList();


                if (Etype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Employee  found");

                }

                else
                {
                    foreach (var a in Etype)
                    {

                        dgvEmployees.DataSource = Etype.Select(col => new { col.Employee_Id,col.Employee_Name, col.Employee_Surname, col.Employee_Tax_Number, col.Employee_Id_Number, col.Employee_Address, col.Employee_Cellphone_Number, col.Employee_Account_Number, col.Employee_Email_Address, col.Employee_Type }).ToList();



                        //groupBox1.Visible = true;
                    }
                }
            }
        }
    }
}
