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
    public partial class frmVehicle : Form
    {
        string option;
        SPEntities3 db = new SPEntities3();
        public frmVehicle(string x)
        {
            option = x;
            InitializeComponent();
            vehicleBindingSource.DataSource = db.Vehicles.ToList();
        }
        
        bool correct = false;

        public int database;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            correct = true;
            Vehicle vehicle = new Vehicle();


            if (txtMake.Text == "" || txtModel.Text == "" || txtRegNo.Text == "" || txtVIN.Text == "")
            {
                MessageBox.Show("Please Enter Vehicle details");
                correct = false;
            }

            if (correct == true)
            {
                vehicle.Vehicle_Make = txtMake.Text;
                vehicle.Vehicle_Model = txtModel.Text;
                vehicle.Vehicle_Registration_Number = txtRegNo.Text;
                Vehicle_Status st = cbxStatus.SelectedItem as Vehicle_Status;
                vehicle.Vehicle_Status_ID = st.Vehicle_Status_ID;
                vehicle.Last_Serviced = dtpLastServiced.Value;
                //vehicle.Vehicle_Status.Vehicle_Status_Description = "Active";// cbxStatus.Text;
                vehicle.VIN_Number = txtVIN.Text;
            }
           // SPEntities db = new SPEntities();
            //var db2 = new SPEntities3()
            
                db.Vehicles.Add(vehicle);
          string Vehicle_value = Convert.ToString(vehicle);
 
                db.SaveChanges();
            
            int vehicle_ID = Convert.ToInt32(vehicle.Vehicle_ID);
             int vehicleS_ID = Convert.ToInt32(vehicle.Vehicle_Status_ID);
            string VehicleS_value = Convert.ToString(vehicle);



            
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

                List<Vehicle> Ptype = db.Vehicles.Where(o => o.Vehicle_Make.Contains(txtSearchVehicle.Text)).ToList();


                if (Ptype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No vehicle found");

                }

                else
                {
                    foreach (var a in Ptype)
                    {

                        dgvVehicle.DataSource = Ptype.Select(col => new { col.Vehicle_ID, col.Vehicle_Make, col.Vehicle_Model, col.Vehicle_Registration_Number, col.VIN_Number, col.Vehicle_Status }).ToList();

                        dgvVehicle.Columns[0].HeaderText = "Vehicle_ID";
                        dgvVehicle.Columns[1].HeaderText = "Vehicle_Make";
                        dgvVehicle.Columns[2].HeaderText = "Vehicle_Model";
                        dgvVehicle.Columns[3].HeaderText = "Vehicle_Registration Nunmber";
                        dgvVehicle.Columns[4].HeaderText = "Vehicle_VIN Number";
                        dgvVehicle.Columns[5].HeaderText = "Vehicle_Status";
                    }
                }
            }
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    int val = Convert.ToInt32(dgvVehicle.CurrentRow.Cells[0].Value);

                    if (option == "Maintain Vehicle Type")
                    {
                        frmVehicleM form1 = new frmVehicleM(val);
                        form1.ShowDialog();

                        this.Close();
                        
                    }

                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Please specify your vehicle search details first");
                }
            }
        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {
            cbxStatus.DataSource = db.Vehicle_Status.ToList();
            cbxStatus.ValueMember = "Vehicle_Status_Description";
            cbxStatus.SelectedIndex = -1;
        }
    }
}

            
