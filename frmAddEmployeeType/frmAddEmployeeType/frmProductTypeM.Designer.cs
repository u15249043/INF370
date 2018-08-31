namespace frmAddEmployeeType
{
    partial class frmProductTypeM
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
            this.btnDeletePT = new System.Windows.Forms.Button();
            this.btnUpdatePT = new System.Windows.Forms.Button();
            this.txtProductTypeDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeletePT
            // 
            this.btnDeletePT.Location = new System.Drawing.Point(570, 350);
            this.btnDeletePT.Name = "btnDeletePT";
            this.btnDeletePT.Size = new System.Drawing.Size(139, 23);
            this.btnDeletePT.TabIndex = 13;
            this.btnDeletePT.Text = "Delete Product Type";
            this.btnDeletePT.UseVisualStyleBackColor = true;
            this.btnDeletePT.Click += new System.EventHandler(this.btnDeletePT_Click_1);
            // 
            // btnUpdatePT
            // 
            this.btnUpdatePT.Location = new System.Drawing.Point(401, 350);
            this.btnUpdatePT.Name = "btnUpdatePT";
            this.btnUpdatePT.Size = new System.Drawing.Size(139, 23);
            this.btnUpdatePT.TabIndex = 12;
            this.btnUpdatePT.Text = "Update Product Type";
            this.btnUpdatePT.UseVisualStyleBackColor = true;
            this.btnUpdatePT.Click += new System.EventHandler(this.btnUpdatePT_Click_1);
            // 
            // txtProductTypeDesc
            // 
            this.txtProductTypeDesc.Location = new System.Drawing.Point(266, 113);
            this.txtProductTypeDesc.Multiline = true;
            this.txtProductTypeDesc.Name = "txtProductTypeDesc";
            this.txtProductTypeDesc.Size = new System.Drawing.Size(443, 207);
            this.txtProductTypeDesc.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product type description";
            // 
            // frmProductTypeM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 458);
            this.Controls.Add(this.btnDeletePT);
            this.Controls.Add(this.btnUpdatePT);
            this.Controls.Add(this.txtProductTypeDesc);
            this.Controls.Add(this.label1);
            this.Name = "frmProductTypeM";
            this.Text = "frmProductTypeM";
            this.Load += new System.EventHandler(this.frmProductTypeM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePT;
        private System.Windows.Forms.Button btnUpdatePT;
        private System.Windows.Forms.TextBox txtProductTypeDesc;
        private System.Windows.Forms.Label label1;
    }
}