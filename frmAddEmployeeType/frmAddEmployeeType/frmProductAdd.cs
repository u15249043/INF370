using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace frmAddEmployeeType
{
    public partial class frmProductAdd : Form
    {/*
        DataSet ds = new DataSet();
        SqlDataAdapter DBAdapter = new SqlDataAdapter();
        */
        SPEntities3 db = new SPEntities3();
        public frmProductAdd()
        {
            InitializeComponent();
            
            productBrandBindingSource.DataSource = db.Product_Brand.ToList();
            sheetBindingSource.DataSource = db.Sheets.ToList();
            widthBindingSource.DataSource = db.Widths.ToList();
            pLengthBindingSource.DataSource = db.pLengths.ToList();
            plyBindingSource.DataSource = db.Plies.ToList();
            packSizeBindingSource.DataSource = db.Pack_Size.ToList();
            productTypeBindingSource.DataSource = db.Product_Type.ToList();
            productImageBindingSource.DataSource = db.Product_Image.ToList();

         }
        bool correct = false;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        byte[] arr;
        ImageConverter converter = new ImageConverter();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bitmap map = new Bitmap(pbxImage.Size.Width, pbxImage.Size.Height);
            arr = (byte[])converter.ConvertTo(map, typeof(byte[]));
            correct = true;
            Product prod = new Product();
            if (txtDescription.Text == "" || numUDQuantity.Value == 0 || cbxprodT.Items == null || cbxbrand.Items == null || cbxPly.Items == null || cbxPackSize.Items == null || cbxSheet.Items == null || cbxLength.Items == null || cbxWidth.Items == null) 
            {

                MessageBox.Show("Please Enter all fields on the product Form");
                correct = false;
            }
            
            if (correct == true)
            {
                
                prod.Product_Brand_ID = Convert.ToInt32(cbxbrand.SelectedValue);
                prod.Length_ID = Convert.ToInt32(cbxLength.SelectedValue);
                prod.Pack_Size_ID = Convert.ToInt32(cbxPackSize.SelectedValue);
                prod.Sheet_ID = Convert.ToInt32(cbxSheet.SelectedValue);
                prod.Ply_ID = Convert.ToInt32(cbxPly.SelectedValue);
                prod.Product_Type_ID = Convert.ToInt32(cbxprodT.SelectedValue);
                prod.Available_Quantity = Convert.ToInt32(numUDQuantity.Value);
                prod.Product_Description = txtDescription.Text;
                prod.Width_ID = Convert.ToInt32(cbxWidth.SelectedValue);


                var image = cbximage.SelectedValue;
                

                db.Products.Add(prod);
                db.SaveChanges();
                MessageBox.Show("Product Added Successfully");

            }
            
            this.Close();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void cbximage_SelectedIndexChanged(object sender, EventArgs e)
        {

           // pbxImage.Image = cbximage.SelectedValue.ToString();
        }
    }
}
