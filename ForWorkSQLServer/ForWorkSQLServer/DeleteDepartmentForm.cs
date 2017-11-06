using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ForWorkSQLServer
{
    public partial class DeleteDepartmentForm : Form
    {
        private Department _selecteDepartment;
        public event Action Deleted;
        
        public DeleteDepartmentForm(Department selecteDepartment){
            InitializeComponent();
            _selecteDepartment = selecteDepartment;
        }

        private void DeleteButton_Click(object sender, EventArgs e){
            if(NameTextBox.Text != "Удалить")return;
            var db = Main.Db;
            var departmentlistToRemove = new List<Department>();
            var employeelistToRemove = new List<Empoyee>();
            var tmp = db.Department.First(l => l.ID == _selecteDepartment.ID);
            FillLists(tmp, departmentlistToRemove, employeelistToRemove);
            foreach (var department in departmentlistToRemove){
                db.Department.Remove(department);
            }
            foreach (var employee in employeelistToRemove){
                db.Empoyee.Remove(employee);
            }
            db.SaveChanges();
            Deleted?.Invoke();
            Close();
        }

        private void FillLists(Department department, List<Department> deplist, List<Empoyee> emplist){
            deplist.Add(department);
            emplist.AddRange(department.Empoyee);
            foreach (var child in department.Department1){
                FillLists(child, deplist,emplist);
            }
        }
    }
}
