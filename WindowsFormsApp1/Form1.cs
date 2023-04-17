using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string result = string.Empty;
        private string gender = string.Empty;
        private string family = string.Empty;
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void male_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) { gender = radioButton.Text; }
        }
        private void female_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) { gender = radioButton.Text; }
        }
        private void married_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) { family = radioButton.Text; }
        }
        private void notMarried_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) { family = radioButton.Text; }
        }
        private void liveWithCats_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked) { family = radioButton.Text; }
        }     
        private void Save_Click(object sender, EventArgs e)
        {
            result = $"Name: {Name.Text}\nSurname: {Surname.Text}\n" +
                $"Second name: {SecondName.Text}\nDate of birth {DateOfBirth.Text}\n" +
                $"\nGender: {gender}\nFamily: {family}\nInfo: {Info.Text}";
            MessageBox.Show(result);

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, result);
            MessageBox.Show("Файл сохранен");
        }              
    }
}
