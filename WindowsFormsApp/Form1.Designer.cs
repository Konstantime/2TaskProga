namespace WindowsFormsApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.FillTableDemoDataButton = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.StudentsGistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StudentTablelistView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(12, 12);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(263, 52);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добавить Студента";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(303, 12);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(265, 52);
            this.DeleteStudentButton.TabIndex = 1;
            this.DeleteStudentButton.Text = "Удалить Студента";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // FillTableDemoDataButton
            // 
            this.FillTableDemoDataButton.Location = new System.Drawing.Point(12, 70);
            this.FillTableDemoDataButton.Name = "FillTableDemoDataButton";
            this.FillTableDemoDataButton.Size = new System.Drawing.Size(556, 52);
            this.FillTableDemoDataButton.TabIndex = 4;
            this.FillTableDemoDataButton.Text = "Заполнить таблицу демонстрационными данными";
            this.FillTableDemoDataButton.UseVisualStyleBackColor = true;
            this.FillTableDemoDataButton.Click += new System.EventHandler(this.FillTableDemoDataButton_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(574, 12);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(134, 16);
            this.feedbackLabel.TabIndex = 13;
            this.feedbackLabel.Text = "Добро пожаловать)";
            this.feedbackLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // StudentsGistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.StudentsGistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StudentsGistogram.Legends.Add(legend1);
            this.StudentsGistogram.Location = new System.Drawing.Point(12, 128);
            this.StudentsGistogram.Name = "StudentsGistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.StudentsGistogram.Series.Add(series1);
            this.StudentsGistogram.Size = new System.Drawing.Size(556, 374);
            this.StudentsGistogram.TabIndex = 14;
            this.StudentsGistogram.Text = "chart1";
            // 
            // StudentTablelistView
            // 
            this.StudentTablelistView.HideSelection = false;
            this.StudentTablelistView.Location = new System.Drawing.Point(577, 36);
            this.StudentTablelistView.Name = "StudentTablelistView";
            this.StudentTablelistView.Size = new System.Drawing.Size(460, 466);
            this.StudentTablelistView.TabIndex = 16;
            this.StudentTablelistView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1049, 508);
            this.Controls.Add(this.StudentTablelistView);
            this.Controls.Add(this.StudentsGistogram);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.FillTableDemoDataButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Name = "Form1";
            this.Text = "DecanatPRO";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button FillTableDemoDataButton;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart StudentsGistogram;
        private System.Windows.Forms.ListView StudentTablelistView;
    }
}

