using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class FinalUpload : UserControl
    {
        public FinalUpload()
        {
            InitializeComponent();
            finalNoteUpload1.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            finalNoteUpload1.BringToFront();
            finalNoteUpload1.Show();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
              
            }
        }
    }
}
