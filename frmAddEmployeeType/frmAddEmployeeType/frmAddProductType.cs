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
    public partial class frmAddProductType : Form
    {
        string option;
        public frmAddProductType(string x)
        {
            option = x;
            InitializeComponent();
        }
        SPEntities3 db = new SPEntities3();
        bool correct = false;
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            correct = true;
            Product_Type prodT = new Product_Type();

            if (rtxtDescription.Text == "")
            {

                MessageBox.Show("Please Enter Product type details");
                correct = false;
            }

            if (correct == true)
            {
                prodT.Product_Type_Name = rtxtDescription.Text;
            }

            db.Product_Type.Add(prodT);

            db.SaveChanges();

            int Product_Type_ID = prodT.Product_Type_ID;
            string ProdT_value = Convert.ToString(prodT);


            var r = db.Product_Type.ToList();
            dgvProductType.DataSource = r.Select(col => new { col.Product_Type_ID, col.Product_Type_Name }).ToList();

            dgvProductType.Columns[0].HeaderText = "Product_Type_ID";
            dgvProductType.Columns[1].HeaderText = "Product_Type";

        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    int val = Convert.ToInt32(dgvProductType.CurrentRow.Cells[0].Value);

                    if (option == "Maintain Product Type")
                    {
                        frmProductTypeM form1 = new frmProductTypeM(val);
                        form1.ShowDialog();

                        this.Close();



                    }

                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Please specify your product type search details first");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchProductT.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchProductT.Text != "")
            {

                List<Product_Type> Ptype = db.Product_Type.Where(o => o.Product_Type_Name.Contains(txtSearchProductT.Text)).ToList();


                if (Ptype.Count == 0)
                {
                    //groupBox1.Visible = true;
                    MessageBox.Show("No Product type found");

                }

                else
                {
                    foreach (var a in Ptype)
                    {

                        dgvProductType.DataSource = Ptype.Select(col => new { col.Product_Type_ID, col.Product_Type_Name }).ToList();

                        dgvProductType.Columns[0].HeaderText = "Product_Type_ID";
                        dgvProductType.Columns[1].HeaderText = "Product_Type_Description";


                        //groupBox1.Visible = true;

                    }
                }
            }
        }
    }
}
