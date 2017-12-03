using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Balls.Logic;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Random;

namespace Balls
{
    public partial class GameDev : Form
    {
        private readonly BallSystem system;
        private Bitmap canvas;

        public GameDev()
        {
            InitializeComponent();

            var radius = 8;

            system = new BallSystem(500, radius, pictureBox1.Width - radius, pictureBox1.Height - radius);
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            system.Move(2f);
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            system.NormalizeSystem();

            using (var graph = Graphics.FromImage(canvas))
            {
                graph.Clear(Color.AliceBlue);

                system.DrawSystem(graph);             
            }

            pictureBox1.Image = canvas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            renderTimer.Stop();           
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            renderTimer.Start();
        }
    }
}
