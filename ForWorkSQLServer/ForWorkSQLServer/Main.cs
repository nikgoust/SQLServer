using System;
using System.Linq;
using System.Windows.Forms;


namespace ForWorkSQLServer
{
    public partial class Main : Form
    {
        public static TestDBEntities Db;
        private Department _selecteDepartment;

        public Main(){
            InitializeComponent();
            Db = new TestDBEntities();
            var departmentList = Db.Department.Where(l => l.ParentDepartmentID == null).ToList();
            foreach (var department in departmentList){
                DepartmentTreeView.Nodes.Add(FillViewTree(department));
            }
            DepartmentTreeView.ExpandAll();
            DepartmentTreeView.NodeMouseDoubleClick += DepartmentTreeView_NodeMouseDoubleClick;
            DepartmentTreeView.AfterSelect += DepartmentTreeView_AfterSelect;
        }



        private TreeNode FillViewTree(Department item){
            var result = new TreeNode(item.Name);
            foreach (var child in item.Department1){
                result.Nodes.Add(FillViewTree(child));
            }
            return result;
        }

        private void DepartmentTreeView_AfterSelect(object sender, TreeViewEventArgs e){
            var treeView = sender as TreeView;
            if(treeView == null)return;
            var node = treeView.SelectedNode;
            _selecteDepartment = Db.Department.ToList().Find(l => l.Name == node?.Text);
            departmentBindingSource.DataSource = _selecteDepartment;
            EmployeeCountLabel.Text = _selecteDepartment.Empoyee.Count.ToString();
        }

        private void DepartmentTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e){
            var newWindow = new EmployeeForm(_selecteDepartment.ID);
            newWindow.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e){
            var newWindow = new AddDepartmentForm(_selecteDepartment.ID);
            newWindow.Added += RefreshTree;
            newWindow.ShowDialog();

        }

        private void RefreshTree(){
            DepartmentTreeView.Nodes.Clear();
            var departmentList = Db.Department.Where(l => l.ParentDepartmentID == null).ToList();
            foreach (var department in departmentList){
                DepartmentTreeView.Nodes.Add(FillViewTree(department));
            }
            DepartmentTreeView.ExpandAll();
        }

        private void DeleteButton_Click(object sender, EventArgs e){
            var newWindow = new DeleteDepartmentForm(_selecteDepartment);
            newWindow.Deleted += RefreshTree;
            newWindow.ShowDialog();
        }
    }
}
