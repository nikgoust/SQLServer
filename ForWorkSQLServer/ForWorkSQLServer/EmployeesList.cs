using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ForWorkSQLServer
{
    public partial class EmployeeForm : Form
    {
        private TestDBEntities _db;
        private List<Empoyee> _employees;
        private Guid _selectedDepartmentId;
        public EmployeeForm(Guid selectedDepartmentId)
        {
            InitializeComponent();
            _db = Main.Db;
            _selectedDepartmentId = selectedDepartmentId;
            InitData();
            DepartmentNameLabel.Text = _db.Department.First(l => l.ID == selectedDepartmentId).Name;
            EmployeeDataGridView.CellDoubleClick += EmployeeDataGridView_CellDoubleClick;
            
           

        }

        private void EmployeeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            var employeeForm = new EmployeeSetup(_selectedDepartmentId, _employees[e.RowIndex].ID);
            employeeForm.Changed += InitData;
            employeeForm.ShowDialog();           
             
             
             
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e){
            var employeeForm=new EmployeeSetup(_selectedDepartmentId);
            employeeForm.Changed += InitData;
            employeeForm.ShowDialog();
        }

        private void InitData(){
            _employees = _db.Empoyee.Where(l => l.DepartmentID == _selectedDepartmentId).ToList();
            empoyeeBindingSource.DataSource = _employees;
        }
    }
}
