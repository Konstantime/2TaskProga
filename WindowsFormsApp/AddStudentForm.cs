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

namespace WindowsFormsApp {
    public partial class AddStudentForm : Form {

        private Logic logic = new Logic();
        public AddStudentForm( Logic logic ) {
            InitializeComponent();
            this.logic = logic;
        }

        private void AddStudentButton_Click(object sender, EventArgs e) {
            string name, speciality, group;
            name = InputNameTextBox.Text;
            speciality = InputSpecialityTextBox.Text;
            group = InputGroupTextBox.Text;

            if (name.Replace(" ", "") != "" && speciality.Replace(" ", "") != "" && group.Replace(" ", "") != "") {
                logic.AddStudent(name, speciality, group);
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Необходимо заполнить все поля!!!");
            }
        }

        private void InputSpecialityTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void CancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
