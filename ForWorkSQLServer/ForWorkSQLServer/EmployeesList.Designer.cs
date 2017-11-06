namespace ForWorkSQLServer
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DepartmentNameLabel = new System.Windows.Forms.Label();
            this.empoyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empoyeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AutoGenerateColumns = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.EmployeeDataGridView.DataSource = this.empoyeeBindingSource;
            this.EmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.Size = new System.Drawing.Size(617, 396);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(658, 39);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(99, 23);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Добавить";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DepartmentNameLabel
            // 
            this.DepartmentNameLabel.AutoSize = true;
            this.DepartmentNameLabel.Location = new System.Drawing.Point(635, 9);
            this.DepartmentNameLabel.Name = "DepartmentNameLabel";
            this.DepartmentNameLabel.Size = new System.Drawing.Size(35, 13);
            this.DepartmentNameLabel.TabIndex = 2;
            this.DepartmentNameLabel.Text = "label1";
            // 
            // empoyeeBindingSource
            // 
            this.empoyeeBindingSource.DataSource = typeof(ForWorkSQLServer.Empoyee);
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 90;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 420);
            this.Controls.Add(this.DepartmentNameLabel);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Name = "EmployeeForm";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empoyeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.BindingSource empoyeeBindingSource;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label DepartmentNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
    }
}

