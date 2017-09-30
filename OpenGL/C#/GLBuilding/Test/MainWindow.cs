using System;
using System.Windows.Forms;
using GLBuilding.Core;
using GLBuilding.Core.BuildingBase;

namespace Test
{
    public partial class MainWindow : Form
    {
        private BuildingArea _buildingArea;

        public MainWindow()
        {
            InitializeComponent();

            AnT.InitializeContexts();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            var ctx = new BuildContext() { ClearColor = Color.Red()};
            _buildingArea = new BuildingArea(ctx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _buildingArea.DrawSphere();
            AnT.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            AnT.Invalidate();
        }
    }
}
