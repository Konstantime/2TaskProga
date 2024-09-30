using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Logic logic = new Logic();
        public Form1() {
            InitializeComponent();
            СustomizeListView();
        }

        private void AddStudentButton_Click(object sender, EventArgs e) {
            AddStudentForm addStudentForm = new AddStudentForm(logic);

            if (addStudentForm.ShowDialog() == DialogResult.OK) {
                UpdateGistogram();
                UpdateListView();
                feedbackLabel.Text = "Студент успешно добавлен)";
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if(StudentTablelistView.SelectedItems.Count <= 0) {
                feedbackLabel.Text = "Для удаления нужно выбрать студента в таблице)";
                return; 
            }
            
            ListViewItem selectedItem = StudentTablelistView.SelectedItems[0];
            int selectedIndex = selectedItem.Index;

            logic.DeleteStudent(selectedIndex);

            UpdateGistogram();
            UpdateListView();
            feedbackLabel.Text = "Удаление успешно)";
        }

        private void UpdateGistogram() {
            Dictionary<string, int> countEverySpeciality = logic.GetCountStudentsOfEverySpeciality();

            List<string> namesSpecialties = new List<string>();
            List<int> countsSpecialties = new List<int>();

            foreach (var item in countEverySpeciality) {
                namesSpecialties.Add(item.Key);
                countsSpecialties.Add(item.Value);
            }

            // Настраиваем диаграмму
            StudentsGistogram.ChartAreas[0].AxisX.Title = "Специальности";
            StudentsGistogram.ChartAreas[0].AxisY.Title = "Количество человек";
            StudentsGistogram.ChartAreas[0].AxisX.Interval = 1;

            // Добавляем серию данных
            StudentsGistogram.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            StudentsGistogram.Series["Series1"].Points.DataBindXY(namesSpecialties, countsSpecialties);
        }

        private void FillTableDemoDataButton_Click(object sender, EventArgs e)
        {
            logic.FillTableWithDemoData();
            feedbackLabel.Text = "Таблица успешно заполнена тестовыми данными)";
            UpdateGistogram();
            UpdateListView();
        }

        private void СustomizeListView() {
            StudentTablelistView.View = View.Details;
            StudentTablelistView.Columns.Add("Индекс", 100);
            StudentTablelistView.Columns.Add("Имя", 100);
            StudentTablelistView.Columns.Add("Специальность", 100);
            StudentTablelistView.Columns.Add("Группа", 100);
        }

        private void UpdateListView() {
            StudentTablelistView.Items.Clear();

            var students = logic.GetAllStudentsFormatArrayOfArrays();

            for (int i = 0; i < students.Length; i++) {
                ListViewItem item = new ListViewItem( Convert.ToString(i) );
                item.SubItems.Add(students[i][0]);
                item.SubItems.Add(students[i][1]);
                item.SubItems.Add(students[i][2]);
                StudentTablelistView.Items.Add(item);
            }
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
