using System;
using System.Linq;
using System.Windows.Forms;

namespace ForWorkSQLServer
{
    public partial class AddDepartmentForm : Form
    {
        private TestDBEntities _db;
        private Guid _perentDepartmentId;
        public event Action Added;

        public AddDepartmentForm(Guid perentDepartmentId){
            InitializeComponent();
            _db = Main.Db; 
            ParentNameLabel.Text = _db.Department.First(l => l.ID == perentDepartmentId).Name;
            _perentDepartmentId = perentDepartmentId;
        }

        private void AddButton_Click(object sender, EventArgs e){
                if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(CodeTextBox.Text)) return;
                var newDepartment = new Department()
                {
                    ID = Guid.NewGuid(),
                    ParentDepartmentID = _perentDepartmentId,
                    Name = NameTextBox.Text,
                    Code = CodeTextBox.Text
                };
                _db.Department.Add(newDepartment);
                _db.SaveChanges();
            Added?.Invoke();
            Close();
        }
    }
}
