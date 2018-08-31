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
    public partial class frmProduct_Maintain : Form
    {
        int tempID;
        public frmProduct_Maintain(int x)
        {
            tempID = x;
            InitializeComponent();

        }
        SPEntities3 db = new SPEntities3();
        bool correct = false;

        private void frmProduct_Maintain_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            correct = true;

            if (txtDescription.Text == "" || numUDQuantity.Value == 0 || cbxprodT.Items == null || cbxbrand.Items == null || cbxPly.Items == null || cbxPackSize.Items == null || cbxSheet.Items == null || cbxLength.Items == null || cbxWidth.Items == null)
            {

                MessageBox.Show("Please Enter all fields on the product Form");
                correct = false;
            }
            if (correct == true)
            {

                var query = db.Products.Where(co => co.Product_ID == tempID).FirstOrDefault();

                query.Product_Brand_ID = Convert.ToInt32(cbxbrand.SelectedValue);
                query.Length_ID = Convert.ToInt32(cbxLength.SelectedValue);
                query.Pack_Size_ID = Convert.ToInt32(cbxPackSize.SelectedValue);
                query.Sheet_ID = Convert.ToInt32(cbxSheet.SelectedValue);
                query.Ply_ID = Convert.ToInt32(cbxPly.SelectedValue);
                query.Product_Type_ID = Convert.ToInt32(cbxprodT.SelectedValue);
                query.Available_Quantity = Convert.ToInt32(numUDQuantity.Value);
                query.Product_Description = txtDescription.Text;
                query.Width_ID = Convert.ToInt32(cbxWidth.SelectedValue);
                db.SaveChanges();

                MessageBox.Show("Product Successfully Updated");
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product?", "Delete Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Product prod2 = new Product();
                    prod2 = db.Products.Find(tempID);

                    db.Products.Remove(prod2);
                    db.SaveChanges();

                    int prodID = prod2.Product_ID;
                    string prodValue = Convert.ToString(prod2);
                    MessageBox.Show("Product Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Product was not deleted");

                }
            }
        }
    }
}
