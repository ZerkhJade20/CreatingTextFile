using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
 
        public FrmRegistration()
        {
            InitializeComponent();

            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNu.Text;
            string lastName = txtLastNamee.Text;
            string firstName = txtFirstNamee.Text;
            string mi = txtMIi.Text;
            string program = cmbProgramm.Text;
            string gender = cmbGenderr.Text;
            string age = txtAgee.Text;
            string birthday = dtpBirthdayy.Value.ToString("yyyy-MM-dd");
            string contact = txtContactt.Text;

          
            if (string.IsNullOrEmpty(studentNo) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please fill in required fields.", "Warning");
                return;
            }

           
            string[] info = new string[]
            {
                "Student No.: " + studentNo,
                "Full Name: " + lastName + ", " + firstName + ", " + mi,
                "Program: " + program,
                "Gender: " + gender,
                "Age: " + age,
                "Birthday: " + birthday,
                "Contact No.: " + contact
            };

           

            try
            {
             string projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string filePath = Path.Combine(projectRoot, "Files");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in info)
                        writer.WriteLine(line);
                }

                MessageBox.Show($"Registration file saved!\n\n{filePath}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file:\n" + ex.Message, "Error");
            }
        }
    }
}
