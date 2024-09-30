namespace WindowsFormsApp {
    partial class AddStudentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.InputGroupTextBox = new System.Windows.Forms.TextBox();
            this.InputGroupLabel = new System.Windows.Forms.Label();
            this.InputSpecialityTextBox = new System.Windows.Forms.TextBox();
            this.InputSpecialityLabel = new System.Windows.Forms.Label();
            this.InputNameTextBox = new System.Windows.Forms.TextBox();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputGroupTextBox
            // 
            this.InputGroupTextBox.Location = new System.Drawing.Point(12, 189);
            this.InputGroupTextBox.Name = "InputGroupTextBox";
            this.InputGroupTextBox.Size = new System.Drawing.Size(552, 22);
            this.InputGroupTextBox.TabIndex = 18;
            // 
            // InputGroupLabel
            // 
            this.InputGroupLabel.AutoSize = true;
            this.InputGroupLabel.Location = new System.Drawing.Point(9, 149);
            this.InputGroupLabel.Name = "InputGroupLabel";
            this.InputGroupLabel.Size = new System.Drawing.Size(180, 16);
            this.InputGroupLabel.TabIndex = 17;
            this.InputGroupLabel.Text = "Введите Группу студента:";
            // 
            // InputSpecialityTextBox
            // 
            this.InputSpecialityTextBox.Location = new System.Drawing.Point(12, 104);
            this.InputSpecialityTextBox.Name = "InputSpecialityTextBox";
            this.InputSpecialityTextBox.Size = new System.Drawing.Size(552, 22);
            this.InputSpecialityTextBox.TabIndex = 16;
            this.InputSpecialityTextBox.TextChanged += new System.EventHandler(this.InputSpecialityTextBox_TextChanged);
            // 
            // InputSpecialityLabel
            // 
            this.InputSpecialityLabel.AutoSize = true;
            this.InputSpecialityLabel.Location = new System.Drawing.Point(9, 74);
            this.InputSpecialityLabel.Name = "InputSpecialityLabel";
            this.InputSpecialityLabel.Size = new System.Drawing.Size(234, 16);
            this.InputSpecialityLabel.TabIndex = 15;
            this.InputSpecialityLabel.Text = "Введите Специальность студента:";
            // 
            // InputNameTextBox
            // 
            this.InputNameTextBox.Location = new System.Drawing.Point(12, 36);
            this.InputNameTextBox.Name = "InputNameTextBox";
            this.InputNameTextBox.Size = new System.Drawing.Size(552, 22);
            this.InputNameTextBox.TabIndex = 14;
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Location = new System.Drawing.Point(9, 10);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(159, 16);
            this.InputNameLabel.TabIndex = 13;
            this.InputNameLabel.Text = "Введите Имя студента:";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(13, 239);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(270, 56);
            this.AddStudentButton.TabIndex = 21;
            this.AddStudentButton.Text = "Готово";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(289, 238);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(275, 56);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 300);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.InputGroupTextBox);
            this.Controls.Add(this.InputGroupLabel);
            this.Controls.Add(this.InputSpecialityTextBox);
            this.Controls.Add(this.InputSpecialityLabel);
            this.Controls.Add(this.InputNameTextBox);
            this.Controls.Add(this.InputNameLabel);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputGroupTextBox;
        private System.Windows.Forms.Label InputGroupLabel;
        private System.Windows.Forms.TextBox InputSpecialityTextBox;
        private System.Windows.Forms.Label InputSpecialityLabel;
        private System.Windows.Forms.TextBox InputNameTextBox;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button CancelButton;
    }
}