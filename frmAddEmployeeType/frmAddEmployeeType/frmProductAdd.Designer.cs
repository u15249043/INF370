namespace frmAddEmployeeType
{
    partial class frmProductAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.cbximage = new System.Windows.Forms.ComboBox();
            this.productImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbxWidth = new System.Windows.Forms.ComboBox();
            this.widthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.cbxLength = new System.Windows.Forms.ComboBox();
            this.pLengthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSheet = new System.Windows.Forms.ComboBox();
            this.sheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cbxPackSize = new System.Windows.Forms.ComboBox();
            this.packSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbxPly = new System.Windows.Forms.ComboBox();
            this.plyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbxprodT = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxbrand = new System.Windows.Forms.ComboBox();
            this.productBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.employeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLengthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 38);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(406, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numUDQuantity
            // 
            this.numUDQuantity.Location = new System.Drawing.Point(163, 123);
            this.numUDQuantity.Name = "numUDQuantity";
            this.numUDQuantity.Size = new System.Drawing.Size(140, 23);
            this.numUDQuantity.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Available Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(163, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(140, 23);
            this.txtDescription.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.pbxImage);
            this.groupBox1.Controls.Add(this.cbximage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxWidth);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbxLength);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbxSheet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbxPackSize);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxPly);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxprodT);
            this.groupBox1.Controls.Add(this.cbxbrand);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.numUDQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 386);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Product Information";
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(651, 256);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(138, 92);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 36;
            this.pbxImage.TabStop = false;
            // 
            // cbximage
            // 
            this.cbximage.DataSource = this.productImageBindingSource;
            this.cbximage.DisplayMember = "Image_File_Path";
            this.cbximage.FormattingEnabled = true;
            this.cbximage.Location = new System.Drawing.Point(649, 213);
            this.cbximage.Name = "cbximage";
            this.cbximage.Size = new System.Drawing.Size(140, 24);
            this.cbximage.TabIndex = 35;
            this.cbximage.ValueMember = "Image_ID";
            this.cbximage.SelectedIndexChanged += new System.EventHandler(this.cbximage_SelectedIndexChanged);
            // 
            // productImageBindingSource
            // 
            this.productImageBindingSource.DataSource = typeof(frmAddEmployeeType.Product_Image);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Image";
            // 
            // cbxWidth
            // 
            this.cbxWidth.DataSource = this.widthBindingSource;
            this.cbxWidth.DisplayMember = "Width_Size";
            this.cbxWidth.FormattingEnabled = true;
            this.cbxWidth.Location = new System.Drawing.Point(649, 174);
            this.cbxWidth.Name = "cbxWidth";
            this.cbxWidth.Size = new System.Drawing.Size(140, 24);
            this.cbxWidth.TabIndex = 33;
            this.cbxWidth.ValueMember = "Width_ID";
            // 
            // widthBindingSource
            // 
            this.widthBindingSource.DataSource = typeof(frmAddEmployeeType.Width);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(492, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Width";
            // 
            // cbxLength
            // 
            this.cbxLength.DataSource = this.pLengthBindingSource;
            this.cbxLength.DisplayMember = "Length_Size";
            this.cbxLength.FormattingEnabled = true;
            this.cbxLength.Location = new System.Drawing.Point(649, 123);
            this.cbxLength.Name = "cbxLength";
            this.cbxLength.Size = new System.Drawing.Size(140, 24);
            this.cbxLength.TabIndex = 31;
            this.cbxLength.ValueMember = "Length_ID";
            // 
            // pLengthBindingSource
            // 
            this.pLengthBindingSource.DataSource = typeof(frmAddEmployeeType.pLength);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(492, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Length";
            // 
            // cbxSheet
            // 
            this.cbxSheet.DataSource = this.sheetBindingSource;
            this.cbxSheet.DisplayMember = "Number_Of_Sheet";
            this.cbxSheet.FormattingEnabled = true;
            this.cbxSheet.Location = new System.Drawing.Point(649, 76);
            this.cbxSheet.Name = "cbxSheet";
            this.cbxSheet.Size = new System.Drawing.Size(140, 24);
            this.cbxSheet.TabIndex = 29;
            this.cbxSheet.ValueMember = "Sheet_ID";
            // 
            // sheetBindingSource
            // 
            this.sheetBindingSource.DataSource = typeof(frmAddEmployeeType.Sheet);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(492, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sheet Number";
            // 
            // cbxPackSize
            // 
            this.cbxPackSize.DataSource = this.packSizeBindingSource;
            this.cbxPackSize.DisplayMember = "Pack_Size_Description";
            this.cbxPackSize.FormattingEnabled = true;
            this.cbxPackSize.Location = new System.Drawing.Point(649, 39);
            this.cbxPackSize.Name = "cbxPackSize";
            this.cbxPackSize.Size = new System.Drawing.Size(140, 24);
            this.cbxPackSize.TabIndex = 27;
            this.cbxPackSize.ValueMember = "Pack_Size_ID";
            // 
            // packSizeBindingSource
            // 
            this.packSizeBindingSource.DataSource = typeof(frmAddEmployeeType.Pack_Size);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pack_Size";
            // 
            // cbxPly
            // 
            this.cbxPly.DataSource = this.plyBindingSource;
            this.cbxPly.DisplayMember = "Number_Of_Ply";
            this.cbxPly.FormattingEnabled = true;
            this.cbxPly.Location = new System.Drawing.Point(163, 267);
            this.cbxPly.Name = "cbxPly";
            this.cbxPly.Size = new System.Drawing.Size(140, 24);
            this.cbxPly.TabIndex = 25;
            this.cbxPly.ValueMember = "Ply_ID";
            // 
            // plyBindingSource
            // 
            this.plyBindingSource.DataSource = typeof(frmAddEmployeeType.Ply);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ply Number";
            // 
            // cbxprodT
            // 
            this.cbxprodT.DataSource = this.productTypeBindingSource;
            this.cbxprodT.DisplayMember = "Product_Type_Name";
            this.cbxprodT.FormattingEnabled = true;
            this.cbxprodT.Location = new System.Drawing.Point(163, 171);
            this.cbxprodT.Name = "cbxprodT";
            this.cbxprodT.Size = new System.Drawing.Size(140, 24);
            this.cbxprodT.TabIndex = 23;
            this.cbxprodT.ValueMember = "Product_Type_ID";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(frmAddEmployeeType.Product_Type);
            // 
            // cbxbrand
            // 
            this.cbxbrand.DataSource = this.productBrandBindingSource;
            this.cbxbrand.DisplayMember = "Product_Brand_Name";
            this.cbxbrand.FormattingEnabled = true;
            this.cbxbrand.Location = new System.Drawing.Point(163, 226);
            this.cbxbrand.Name = "cbxbrand";
            this.cbxbrand.Size = new System.Drawing.Size(140, 24);
            this.cbxbrand.TabIndex = 22;
            this.cbxbrand.ValueMember = "Product_Brand_ID";
            // 
            // productBrandBindingSource
            // 
            this.productBrandBindingSource.DataSource = typeof(frmAddEmployeeType.Product_Brand);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Brand";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Product_Type";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 488);
            this.panel4.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 488);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // employeeTypeBindingSource
            // 
            this.employeeTypeBindingSource.DataSource = typeof(frmAddEmployeeType.Employee_Type);
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLengthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBrandBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numUDQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSheet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxPackSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxPly;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxprodT;
        private System.Windows.Forms.ComboBox cbxbrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource widthBindingSource;
        private System.Windows.Forms.BindingSource pLengthBindingSource;
        private System.Windows.Forms.BindingSource sheetBindingSource;
        private System.Windows.Forms.BindingSource packSizeBindingSource;
        private System.Windows.Forms.BindingSource plyBindingSource;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource;
        private System.Windows.Forms.BindingSource productBrandBindingSource;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.ComboBox cbximage;
        private System.Windows.Forms.BindingSource productImageBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxImage;
    }
}