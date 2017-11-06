namespace ForWorkSQLServer
{
    partial class AddDepartmentForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ParentNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(106, 95);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вышестоящий отдел";
            // 
            // ParentNameLabel
            // 
            this.ParentNameLabel.AutoSize = true;
            this.ParentNameLabel.Location = new System.Drawing.Point(130, 9);
            this.ParentNameLabel.Name = "ParentNameLabel";
            this.ParentNameLabel.Size = new System.Drawing.Size(0, 13);
            this.ParentNameLabel.TabIndex = 2;
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Name", true));
            this.NameTextBox.Location = new System.Drawing.Point(78, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Code", true));
            this.CodeTextBox.Location = new System.Drawing.Point(78, 65);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(91, 20);
            this.CodeTextBox.TabIndex = 5;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(ForWorkSQLServer.Department);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ParentNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Name = "AddDepartmentForm";
            this.Text = "Добовление отдела";
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ParentNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodeTextBox;
    }
}