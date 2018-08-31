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
    public partial class frmVehicleM : Form
    {
        int tempID;
        public frmVehicleM(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        SPEntities3 db = new SPEntities3();

        private void frmVehicleM_Load(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            var quer1y = db.Vehicles.Where(co => co.Vehicle_ID == tempID).FirstOrDefault();

            cbxStatus.DataSource = db.Vehicle_Status.ToList();
            cbxStatus.ValueMember = "Vehicle_Status_Description";
            cbxStatus.SelectedIndex = -1;

        }//form load
        bool correct = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            correct = true;

            if (txtMake.Text == "")
            {

                MessageBox.Show("Please Enter a Vehicle Make");
                correct = false;
            }
            if (txtModel.Text == "")
            {

                MessageBox.Show("Please Enter a Vehicle Model");
                correct = false;
            }
            if (txtRegNo.Text == "")
            {

                MessageBox.Show("Please Enter a Vehicle Registration Number");
                correct = false;
            }
            if (txtVIN.Text == "")
            {

                MessageBox.Show("Please Enter a Vehicle VIN Code");
                correct = false;
            }


            if (correct == true)
            {

                var query = db.Vehicles.Where(co => co.Vehicle_ID == tempID).FirstOrDefault();

                query.Vehicle_Make = txtMake.Text;
                query.Vehicle_Model = txtModel.Text;
                query.Vehicle_Registration_Number = txtRegNo.Text;
                query.VIN_Number = txtVIN.Text;
                //query.Vehicle_Status = cbxStatus.Text;


                db.SaveChanges();
                MessageBox.Show("Product Type Successfully Updated");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Vehicle VehicleM = new Vehicle();
                    VehicleM = db.Vehicles.Find(tempID);

                    db.Vehicles.Remove(VehicleM);
                    db.SaveChanges();

                    int vehM = Convert.ToInt32(VehicleM.Vehicle_ID);
                    string Vehicle_Value = Convert.ToString(VehicleM);
                    MessageBox.Show("Vehicle Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Vehicle was not deleted");

                }
            }
        }
    }
}
