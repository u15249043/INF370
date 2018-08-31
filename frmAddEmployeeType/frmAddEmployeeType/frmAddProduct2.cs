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
    public partial class frmAddProduct2 : Form
    {
        public frmAddProduct2()
        {
            InitializeComponent();
        }
        SPEntities3 db = new SPEntities3();

        private void frmAddProduct2_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = db.Products.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchProduct.Text != "")
            {

                List<Product> Ptype = db.Products.Where(o => o.Product_Description.Contains(txtSearchProduct.Text)).ToList();


                if (Ptype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Product  found");

                }

                else
                {
                    foreach (var a in Ptype)
                    {

                        dgvProduct.DataSource = Ptype.Select(col => new { col.Product_Description, col.Available_Quantity, col.Product_Type, col.Product_Brand, col.Ply, col.Pack_Size, col.Sheet, col.pLength, col.Width }).ToList();
                        // add image to dgv



                        //groupBox1.Visible = true;
                    }
                }
            }
        }
    }
}
