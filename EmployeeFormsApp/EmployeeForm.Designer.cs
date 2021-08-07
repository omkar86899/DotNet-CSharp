
namespace EmployeeFormsApp
{
    partial class EmployeeForm
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
            this.displayDeptButton = new System.Windows.Forms.Button();
            this.displayEmpButton = new System.Windows.Forms.Button();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.dataGridDept = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDept)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDeptButton
            // 
            this.displayDeptButton.Location = new System.Drawing.Point(750, 12);
            this.displayDeptButton.Name = "displayDeptButton";
            this.displayDeptButton.Size = new System.Drawing.Size(124, 43);
            this.displayDeptButton.TabIndex = 1;
            this.displayDeptButton.Text = "Show Dept";
            this.displayDeptButton.UseVisualStyleBackColor = true;
            this.displayDeptButton.Click += new System.EventHandler(this.displayDeptButton_Click);
            // 
            // displayEmpButton
            // 
            this.displayEmpButton.Location = new System.Drawing.Point(162, 12);
            this.displayEmpButton.Name = "displayEmpButton";
            this.displayEmpButton.Size = new System.Drawing.Size(129, 43);
            this.displayEmpButton.TabIndex = 2;
            this.displayEmpButton.Text = "Show Emp";
            this.displayEmpButton.UseVisualStyleBackColor = true;
            this.displayEmpButton.Click += new System.EventHandler(this.displayEmpButton_Click);
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Location = new System.Drawing.Point(12, 61);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.RowHeadersWidth = 51;
            this.dataGridEmp.RowTemplate.Height = 24;
            this.dataGridEmp.Size = new System.Drawing.Size(528, 441);
            this.dataGridEmp.TabIndex = 3;
            // 
            // dataGridDept
            // 
            this.dataGridDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDept.Location = new System.Drawing.Point(546, 61);
            this.dataGridDept.Name = "dataGridDept";
            this.dataGridDept.RowHeadersWidth = 51;
            this.dataGridDept.RowTemplate.Height = 24;
            this.dataGridDept.Size = new System.Drawing.Size(583, 441);
            this.dataGridDept.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 514);
            this.Controls.Add(this.dataGridDept);
            this.Controls.Add(this.dataGridEmp);
            this.Controls.Add(this.displayEmpButton);
            this.Controls.Add(this.displayDeptButton);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button displayDeptButton;
        private System.Windows.Forms.Button displayEmpButton;
        private System.Windows.Forms.DataGridView dataGridEmp;
        private System.Windows.Forms.DataGridView dataGridDept;
    }
}

