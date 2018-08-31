namespace frmAddEmployeeType
{
    partial class frmDash
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
            this.Vehicle = new System.Windows.Forms.Button();
            this.btnProductType = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeType = new System.Windows.Forms.Button();
            this.btnMaintainEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vehicle
            // 
            this.Vehicle.Location = new System.Drawing.Point(78, 206);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(129, 23);
            this.Vehicle.TabIndex = 9;
            this.Vehicle.Text = "Add Vehicle";
            this.Vehicle.UseVisualStyleBackColor = true;
            this.Vehicle.Click += new System.EventHandler(this.Vehicle_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Location = new System.Drawing.Point(78, 166);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Size = new System.Drawing.Size(129, 23);
            this.btnProductType.TabIndex = 8;
            this.btnProductType.Text = "Add Product Type";
            this.btnProductType.UseVisualStyleBackColor = true;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(78, 33);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(129, 23);
            this.btnMakeSale.TabIndex = 7;
            this.btnMakeSale.Text = "Make Sale";
            this.btnMakeSale.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(78, 126);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(129, 23);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Add Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnEmployeeType
            // 
            this.btnEmployeeType.Location = new System.Drawing.Point(78, 88);
            this.btnEmployeeType.Name = "btnEmployeeType";
            this.btnEmployeeType.Size = new System.Drawing.Size(129, 23);
            this.btnEmployeeType.TabIndex = 5;
            this.btnEmployeeType.Text = "Add Employee Type";
            this.btnEmployeeType.UseVisualStyleBackColor = true;
            this.btnEmployeeType.Click += new System.EventHandler(this.btnEmployeeType_Click);
            // 
            // btnMaintainEmployee
            // 
            this.btnMaintainEmployee.Location = new System.Drawing.Point(227, 126);
            this.btnMaintainEmployee.Name = "btnMaintainEmployee";
            this.btnMaintainEmployee.Size = new System.Drawing.Size(149, 23);
            this.btnMaintainEmployee.TabIndex = 10;
            this.btnMaintainEmployee.Text = "Maintain Employee";
            this.btnMaintainEmployee.UseVisualStyleBackColor = true;
            this.btnMaintainEmployee.Click += new System.EventHandler(this.btnMaintainEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "MaintainProduct";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Maintain Product Type";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Maintain Vehicle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(227, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Maintain Employee Type";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 371);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaintainEmployee);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.btnProductType);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnEmployeeType);
            this.Name = "frmDash";
            this.Text = "frmDash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vehicle;
        private System.Windows.Forms.Button btnProductType;
        private System.Windows.Forms.Button btnMakeSale;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnEmployeeType;
        private System.Windows.Forms.Button btnMaintainEmployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}