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
    public partial class frmMaintainV : Form
    {
        public frmMaintainV()
        {
            InitializeComponent();
        }
        SPEntities3 db = new SPEntities3();
        private void frmMaintainV_Load(object sender, EventArgs e)
        {
            dgvVehicle.DataSource = db.Vehicles.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchVehicle.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchVehicle.Text != "")
            {

                List<Vehicle> Vtype = db.Vehicles.Where(o => o.Vehicle_Registration_Number.Contains(txtSearchVehicle.Text)).ToList();


                if (Vtype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Vehicle  found");

                }

                else
                {
                    foreach (var a in Vtype)
                    {

                        dgvVehicle.DataSource = Vtype.Select(col => new { col.Vehicle_ID, col.Vehicle_Make, col.Vehicle_Model, col.Vehicle_Registration_Number, col.Vehicle_Status, col.VIN_Number}).ToList();



                        //groupBox1.Visible = true;
                    }
                }
            }
        }

        private void btnMaintainV_Click(object sender, EventArgs e)
        {
            frmMaintainEmployee empM = new frmMaintainEmployee(0);
            empM.ShowDialog();

        }
    }
}
