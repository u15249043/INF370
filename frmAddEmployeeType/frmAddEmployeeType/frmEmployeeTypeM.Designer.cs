namespace frmAddEmployeeType
{
    partial class frmEmployeeTypeM
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
            this.btnDeleteET = new System.Windows.Forms.Button();
            this.btnUpdateET = new System.Windows.Forms.Button();
            this.txtEmployeeTypeDesc = new System.Windows.Forms.TextBox();
            this.txtEmployeeTypes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteET
            // 
            this.btnDeleteET.Location = new System.Drawing.Point(532, 343);
            this.btnDeleteET.Name = "btnDeleteET";
            this.btnDeleteET.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteET.TabIndex = 17;
            this.btnDeleteET.Text = "Delete Employee Type";
            this.btnDeleteET.UseVisualStyleBackColor = true;
            this.btnDeleteET.Click += new System.EventHandler(this.btnDeleteET_Click_1);
            // 
            // btnUpdateET
            // 
            this.btnUpdateET.Location = new System.Drawing.Point(363, 343);
            this.btnUpdateET.Name = "btnUpdateET";
            this.btnUpdateET.Size = new System.Drawing.Size(139, 23);
            this.btnUpdateET.TabIndex = 16;
            this.btnUpdateET.Text = "Update Employee Type";
            this.btnUpdateET.UseVisualStyleBackColor = true;
            this.btnUpdateET.Click += new System.EventHandler(this.btnUpdateET_Click);
            // 
            // txtEmployeeTypeDesc
            // 
            this.txtEmployeeTypeDesc.Location = new System.Drawing.Point(228, 106);
            this.txtEmployeeTypeDesc.Multiline = true;
            this.txtEmployeeTypeDesc.Name = "txtEmployeeTypeDesc";
            this.txtEmployeeTypeDesc.Size = new System.Drawing.Size(443, 207);
            this.txtEmployeeTypeDesc.TabIndex = 15;
            // 
            // txtEmployeeTypes
            // 
            this.txtEmployeeTypes.Location = new System.Drawing.Point(311, 46);
            this.txtEmployeeTypes.Name = "txtEmployeeTypes";
            this.txtEmployeeTypes.Size = new System.Drawing.Size(360, 20);
            this.txtEmployeeTypes.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee type ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee type description";
            // 
            // frmEmployeeTypeM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 413);
            this.Controls.Add(this.btnDeleteET);
            this.Controls.Add(this.btnUpdateET);
            this.Controls.Add(this.txtEmployeeTypeDesc);
            this.Controls.Add(this.txtEmployeeTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeTypeM";
            this.Text = "frmEmployeeTypeM";
            this.Load += new System.EventHandler(this.frmEmployeeTypeM_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteET;
        private System.Windows.Forms.Button btnUpdateET;
        private System.Windows.Forms.TextBox txtEmployeeTypeDesc;
        private System.Windows.Forms.TextBox txtEmployeeTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}