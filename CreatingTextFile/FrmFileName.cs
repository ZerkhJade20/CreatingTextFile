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
    public partial class FrmFileName : Form
    {
        public static string SetFileName = string.Empty;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Please enter a filename.", "Warning");
                return;
            }

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c.ToString(), "");
            }

            SetFileName = fileName + ".txt";
            this.Close();
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
        }
    }
    
}
