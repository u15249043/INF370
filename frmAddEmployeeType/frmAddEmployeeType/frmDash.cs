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
    public partial class frmDash : Form
    {
        public frmDash()
        {
            InitializeComponent();
        }

        private void btnEmployeeType_Click(object sender, EventArgs e)
        {
            Form1 forma = new Form1("Maintain Employee Type");
            forma.ShowDialog();
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            frmAddProductType forma = new frmAddProductType("Maintain Product Type");
            forma.ShowDialog();
        }

        private void Vehicle_Click(object sender, EventArgs e)
        {
            frmVehicle formV = new frmVehicle("Maintain Vehicle");
            formV.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee formE = new frmAddEmployee();
            formE.ShowDialog();
        }

        private void btnMaintainEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeM mEmployee = new frmEmployeeM();
            mEmployee.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMaintainEmployeeType formd = new frmMaintainEmployeeType("Maintain Employee Type");
            formd.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductAdd product = new frmProductAdd();
            product.ShowDialog();
        }
    }
}
