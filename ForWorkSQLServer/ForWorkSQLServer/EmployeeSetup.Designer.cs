namespace ForWorkSQLServer
{
    partial class EmployeeSetup
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.BirthDayLable = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.DocSeriesTextBox = new System.Windows.Forms.TextBox();
            this.DocSeriesLabel = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DocNumberTextBox = new System.Windows.Forms.TextBox();
            this.DocNumberLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StateLabel = new System.Windows.Forms.Label();
            this.BirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeValueLabel = new System.Windows.Forms.Label();
            this.empoyeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empoyeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя*";
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "FirstName", true));
            this.NameTextBox.Location = new System.Drawing.Point(106, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "SurName", true));
            this.SurNameTextBox.Location = new System.Drawing.Point(106, 38);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.SurNameTextBox.TabIndex = 3;
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(14, 41);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(60, 13);
            this.SurNameLabel.TabIndex = 2;
            this.SurNameLabel.Text = "Фамилия*";
            // 
            // BirthDayLable
            // 
            this.BirthDayLable.AutoSize = true;
            this.BirthDayLable.Location = new System.Drawing.Point(14, 93);
            this.BirthDayLable.Name = "BirthDayLable";
            this.BirthDayLable.Size = new System.Drawing.Size(90, 13);
            this.BirthDayLable.TabIndex = 6;
            this.BirthDayLable.Text = "Дата рождения*";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "Patronymic", true));
            this.PatronymicTextBox.Location = new System.Drawing.Point(106, 64);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(120, 20);
            this.PatronymicTextBox.TabIndex = 5;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Location = new System.Drawing.Point(14, 67);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(54, 13);
            this.PatronymicLabel.TabIndex = 4;
            this.PatronymicLabel.Text = "Отчество";
            // 
            // DocSeriesTextBox
            // 
            this.DocSeriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "DocSeries", true));
            this.DocSeriesTextBox.Location = new System.Drawing.Point(107, 142);
            this.DocSeriesTextBox.Name = "DocSeriesTextBox";
            this.DocSeriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocSeriesTextBox.TabIndex = 11;
            // 
            // DocSeriesLabel
            // 
            this.DocSeriesLabel.AutoSize = true;
            this.DocSeriesLabel.Location = new System.Drawing.Point(14, 145);
            this.DocSeriesLabel.Name = "DocSeriesLabel";
            this.DocSeriesLabel.Size = new System.Drawing.Size(88, 13);
            this.DocSeriesLabel.TabIndex = 10;
            this.DocSeriesLabel.Text = "Серия паспорта";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "Position", true));
            this.PositionTextBox.Location = new System.Drawing.Point(106, 116);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 9;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(14, 119);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(69, 13);
            this.PositionLabel.TabIndex = 8;
            this.PositionLabel.Text = "Должность*";
            // 
            // DocNumberTextBox
            // 
            this.DocNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empoyeeBindingSource, "DocNumber", true));
            this.DocNumberTextBox.Location = new System.Drawing.Point(107, 168);
            this.DocNumberTextBox.Name = "DocNumberTextBox";
            this.DocNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.DocNumberTextBox.TabIndex = 13;
            // 
            // DocNumberLabel
            // 
            this.DocNumberLabel.AutoSize = true;
            this.DocNumberLabel.Location = new System.Drawing.Point(14, 171);
            this.DocNumberLabel.Name = "DocNumberLabel";
            this.DocNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.DocNumberLabel.TabIndex = 12;
            this.DocNumberLabel.Text = "Номер паспорта";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 246);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(105, 246);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(195, 246);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StateLabel.Location = new System.Drawing.Point(14, 230);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(203, 13);
            this.StateLabel.TabIndex = 17;
            this.StateLabel.Text = "Поля с * обязательны для заполнения";
            // 
            // BirthDayDateTimePicker
            // 
            this.BirthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empoyeeBindingSource, "DateOfBirth", true));
            this.BirthDayDateTimePicker.Location = new System.Drawing.Point(107, 90);
            this.BirthDayDateTimePicker.Name = "BirthDayDateTimePicker";
            this.BirthDayDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.BirthDayDateTimePicker.TabIndex = 18;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(14, 197);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(49, 13);
            this.AgeLabel.TabIndex = 19;
            this.AgeLabel.Text = "Возраст";
            // 
            // AgeValueLabel
            // 
            this.AgeValueLabel.AutoSize = true;
            this.AgeValueLabel.Location = new System.Drawing.Point(105, 197);
            this.AgeValueLabel.Name = "AgeValueLabel";
            this.AgeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.AgeValueLabel.TabIndex = 20;
            // 
            // empoyeeBindingSource
            // 
            this.empoyeeBindingSource.DataSource = typeof(ForWorkSQLServer.Empoyee);
            // 
            // EmployeeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 273);
            this.Controls.Add(this.AgeValueLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.BirthDayDateTimePicker);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DocNumberTextBox);
            this.Controls.Add(this.DocNumberLabel);
            this.Controls.Add(this.DocSeriesTextBox);
            this.Controls.Add(this.DocSeriesLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.BirthDayLable);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "EmployeeSetup";
            ((System.ComponentModel.ISupportInitialize)(this.empoyeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurNameTextBox;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label BirthDayLable;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.TextBox DocSeriesTextBox;
        private System.Windows.Forms.Label DocSeriesLabel;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox DocNumberTextBox;
        private System.Windows.Forms.Label DocNumberLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource empoyeeBindingSource;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.DateTimePicker BirthDayDateTimePicker;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label AgeValueLabel;
    }
}