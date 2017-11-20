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
using FormParser.ControlFabric;
using Newtonsoft.Json;

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
            var json = File.ReadAllText(openFileDialog1.FileName);

            var formParser = new FormParser(new ControlSpecFabric());

            var control = formParser.ParseFromJson(json);

            control.Show();
        }
    }
}
