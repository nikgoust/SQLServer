using System;
using System.Linq;
using System.Windows.Forms;

namespace ForWorkSQLServer
{
    public partial class EmployeeSetup : Form
    {
        private TestDBEntities _db;
        private Guid _selectedDepartmentId;
        private Empoyee _selectedEmployee;
        public event Action Changed;

        public EmployeeSetup(Guid selectedDepartmentId){
            InitializeComponent();
            _db = Main.Db;
            _selectedDepartmentId = selectedDepartmentId;
            SaveButton.Visible = false;
            DeleteButton.Visible = false;
            AgeLabel.Visible = false;
            AgeValueLabel.Visible = false;
        }

        public EmployeeSetup(Guid selectedDepartmentId, decimal id){
            InitializeComponent();
            _db = Main.Db;
            _selectedDepartmentId = selectedDepartmentId;
            AddButton.Visible = false;
            _selectedEmployee = _db.Empoyee.First(l => l.ID == id);
            empoyeeBindingSource.DataSource = _selectedEmployee;
            var age = (DateTime.Today.Year - _selectedEmployee.DateOfBirth.Year);
            if (_selectedEmployee.DateOfBirth.AddYears(age) > DateTime.Today) age--;
            AgeValueLabel.Text = ""+age;
        }

        private void SaveButton_Click(object sender, EventArgs e){
            if (!ValidValue()){
                StateLabel.Text = "Не корректные данные";
                return;
            }
            _selectedEmployee.DateOfBirth = BirthDayDateTimePicker.Value;
            _selectedEmployee.FirstName = NameTextBox.Text;
            _selectedEmployee.SurName = SurNameTextBox.Text;
            _selectedEmployee.Patronymic = PatronymicTextBox.Text;
            _selectedEmployee.Position = PositionTextBox.Text;
            _selectedEmployee.DocNumber = DocNumberTextBox.Text;
            _selectedEmployee.DocSeries = DocSeriesTextBox.Text;
            _db.SaveChanges();
            Changed?.Invoke();
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e){
            if (!ValidValue())
            {
                StateLabel.Text = "Не корректные данные";
                return;
            }
                var newEmployee = new Empoyee(){
                    FirstName = NameTextBox.Text,
                    SurName = SurNameTextBox.Text,
                    Patronymic = PatronymicTextBox.Text,
                    DocNumber = DocNumberTextBox.Text,
                    DocSeries = DocSeriesTextBox.Text,
                    DepartmentID = _selectedDepartmentId,
                    DateOfBirth = BirthDayDateTimePicker.Value,
                    Position = PositionTextBox.Text
                };
                _db.Empoyee.Add(newEmployee);
                _db.SaveChanges();
            Changed?.Invoke();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _db.Empoyee.Remove(_selectedEmployee);
            _db.SaveChanges();
            Changed?.Invoke();
            Close();
        }

        private bool ValidValue(){
            if (string.IsNullOrEmpty(NameTextBox.Text) 
                ||string.IsNullOrEmpty(SurNameTextBox.Text) 
                ||string.IsNullOrEmpty(PositionTextBox.Text) 
                ||BirthDayDateTimePicker.Value >= DateTime.Today
                ||DocNumberTextBox.Text.Length > 6
                ||DocSeriesTextBox.Text.Length > 4)
                return false;
            return true;
        }
    }
}
