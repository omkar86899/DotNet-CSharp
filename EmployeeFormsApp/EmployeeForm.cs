using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeFormsApp
{
    public partial class EmployeeForm : Form
    {
        private DataSet _dataSet;
        public EmployeeForm()
        {
            _dataSet = new DataSet();
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            SqlCommand sqlCommand_emp, sqlCommand_dept;
            SqlDataAdapter sqlDataAdapter;

            sqlCommand_emp = new SqlCommand("SELECT * FROM EMP;", sqlConnection);
            sqlCommand_dept = new SqlCommand("SELECT * FROM DEPT", sqlConnection);

            sqlDataAdapter = new SqlDataAdapter(sqlCommand_emp);
            sqlDataAdapter.Fill(_dataSet, "empTable");
            sqlDataAdapter = new SqlDataAdapter(sqlCommand_dept);
            sqlDataAdapter.Fill(_dataSet, "deptTable");
            
            InitializeComponent();
        }

        private void displayDeptButton_Click(object sender, EventArgs e)
        {
            dataGridDept.DataSource = _dataSet.Tables["deptTable"];
        }

        private void displayEmpButton_Click(object sender, EventArgs e)
        {
            dataGridEmp.DataSource = _dataSet.Tables["empTable"];
        }
    }
}
