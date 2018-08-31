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
    public partial class frmMaintainEmployeeType : Form
    {
        string option;
        public frmMaintainEmployeeType(string x)
        {
            InitializeComponent();
            option = x;
        }
        SPEntities3 db = new SPEntities3();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchEmployeeT.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchEmployeeT.Text != "")
            {

                List<Employee_Type> Etype = db.Employee_Type.Where(o => o.Employees_Type1.Contains(txtSearchEmployeeT.Text)).ToList();


                if (Etype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Employee type found");

                }

                else
                {
                    foreach (var a in Etype)
                    {

                        dgvEmployeeType.DataSource = Etype.Select(col => new { col.Employee_Type_ID, col.Employees_Type1, col.Employees_Type_Description }).ToList();

                        

                        //groupBox1.Visible = true;
                    }
                }
            }
        }



private void btnMaintain_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dgvEmployeeType.CurrentRow.Cells[0].Value);

                if (option == "Maintain Employee Type")
                {
                    frmEmployeeTypeM form1 = new frmEmployeeTypeM(val);
                    form1.ShowDialog();

                    this.Close();



                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your marketing template search details first");
            }
        }

        private void frmMaintainEmployeeType_Load(object sender, EventArgs e)
        {
            dgvEmployeeType.DataSource = db.Employee_Type.ToList();
        }
    }
}

