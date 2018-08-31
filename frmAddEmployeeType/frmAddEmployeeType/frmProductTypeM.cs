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
    public partial class frmProductTypeM : Form
    { 
        int tempID;
        public frmProductTypeM(int x)
        {
            tempID = x;
            InitializeComponent();
        }
       SPEntities3 db = new SPEntities3();
        // string Desc;
        // string iText;

        bool correct = false;
       
        private void frmProductTypeM_Load(object sender, EventArgs e)
        {
            var query = db.Product_Type.Where(co => co.Product_Type_ID == tempID).FirstOrDefault();

            txtProductTypeDesc.Text = query.Product_Type_Name;

        }

        private void btnUpdatePT_Click_1(object sender, EventArgs e)
        {

            correct = true;

            if (txtProductTypeDesc.Text == "")
            {

                MessageBox.Show("Please Enter a product type Description");
                correct = false;
            }


            if (correct == true)
            {

                var query = db.Product_Type.Where(co => co.Product_Type_ID == tempID).FirstOrDefault();

                query.Product_Type_Name = txtProductTypeDesc.Text;

                db.SaveChanges();
                MessageBox.Show("Product Type Successfully Updated");
                this.Close();
            }
        }

        private void btnDeletePT_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Product Type?", "Delete Product Type", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Product_Type prodT2 = new Product_Type();
                    prodT2 = db.Product_Type.Find(tempID);

                    db.Product_Type.Remove(prodT2);
                    db.SaveChanges();

                    int prodType = prodT2.Product_Type_ID;
                    string prodType_Value = Convert.ToString(prodT2);
                    MessageBox.Show("Product Type Successfully Deleted");
                    this.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Product Type was not deleted");

                }
            }
        }
    }
}
