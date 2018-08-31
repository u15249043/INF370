namespace frmAddEmployeeType
{
    partial class frmMaintainEmployeeType
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
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchEmployeeT = new System.Windows.Forms.TextBox();
            this.dgvEmployeeType = new System.Windows.Forms.DataGridView();
            this.employeeTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesType1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaintain
            // 
            this.btnMaintain.Location = new System.Drawing.Point(633, 261);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(75, 23);
            this.btnMaintain.TabIndex = 24;
            this.btnMaintain.Text = "Maintain";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(585, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEmployeeT
            // 
            this.txtSearchEmployeeT.Location = new System.Drawing.Point(268, 48);
            this.txtSearchEmployeeT.Name = "txtSearchEmployeeT";
            this.txtSearchEmployeeT.Size = new System.Drawing.Size(294, 20);
            this.txtSearchEmployeeT.TabIndex = 22;
            // 
            // dgvEmployeeType
            // 
            this.dgvEmployeeType.AutoGenerateColumns = false;
            this.dgvEmployeeType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeTypeIDDataGridViewTextBoxColumn,
            this.employeesTypeDescriptionDataGridViewTextBoxColumn,
            this.employeesType1DataGridViewTextBoxColumn});
            this.dgvEmployeeType.DataSource = this.employeeTypeBindingSource;
            this.dgvEmployeeType.Location = new System.Drawing.Point(268, 112);
            this.dgvEmployeeType.Name = "dgvEmployeeType";
            this.dgvEmployeeType.Size = new System.Drawing.Size(343, 126);
            this.dgvEmployeeType.TabIndex = 21;
            // 
            // employeeTypeIDDataGridViewTextBoxColumn
            // 
            this.employeeTypeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_Type_ID";
            this.employeeTypeIDDataGridViewTextBoxColumn.HeaderText = "Employee_Type_ID";
            this.employeeTypeIDDataGridViewTextBoxColumn.Name = "employeeTypeIDDataGridViewTextBoxColumn";
            // 
            // employeesTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.employeesTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Employees_Type_Description";
            this.employeesTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "Employees_Type_Description";
            this.employeesTypeDescriptionDataGridViewTextBoxColumn.Name = "employeesTypeDescriptionDataGridViewTextBoxColumn";
            // 
            // employeesType1DataGridViewTextBoxColumn
            // 
            this.employeesType1DataGridViewTextBoxColumn.DataPropertyName = "Employees_Type1";
            this.employeesType1DataGridViewTextBoxColumn.HeaderText = "Employees_Type1";
            this.employeesType1DataGridViewTextBoxColumn.Name = "employeesType1DataGridViewTextBoxColumn";
            // 
            // employeeTypeBindingSource
            // 
            this.employeeTypeBindingSource.DataSource = typeof(frmAddEmployeeType.Employee_Type);
            // 
            // frmMaintainEmployeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 442);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchEmployeeT);
            this.Controls.Add(this.dgvEmployeeType);
            this.Name = "frmMaintainEmployeeType";
            this.Text = "frmMaintainEmployeeType";
            this.Load += new System.EventHandler(this.frmMaintainEmployeeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEmployeeT;
        private System.Windows.Forms.DataGridView dgvEmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesType1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeTypeBindingSource;
    }
}