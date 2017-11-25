using System;
using System.IO;
using System.Windows.Forms;

namespace FormParser
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog1.SafeFileName;
                buttonShow.Enabled = true;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
        }
    }
}
