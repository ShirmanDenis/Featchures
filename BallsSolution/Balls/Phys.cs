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

namespace Balls
{
    public partial class Phys : Form
    {
        private bool moveEnabled = false;

        private readonly PhysSystem system = new PhysSystem();
        
        private Bitmap canvas;

        public Phys()
        {
            InitializeComponent();
            
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            KeyPreview = true;
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            using (var graph = Graphics.FromImage(canvas))
            {
                graph.Clear(Color.AliceBlue);
                DrawNet(graph);
                system.DrawSystem(graph);
            }
            
            if (moveEnabled)
                system.Move(1);

            pictureBox1.Image = canvas;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            renderTimer.Stop();

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            renderTimer.Start();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var existingBall = system.GetBallAt(e.Location);
            if (existingBall != null)
            {
                ballEditor1.SetBall(existingBall);
                return;
            }

            var addBallDialog = new AddBallDialog(e.Location, pictureBox1.Width, pictureBox1.Height);
            var dialogResult = addBallDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var newBall = new PhysicBall
                {
                    Location =
                    {
                        [0] = addBallDialog.Position.X,
                        [1] = addBallDialog.Position.Y
                    },
                    Speed =
                    {
                        [0] = addBallDialog.Speed.X,
                        [1] = addBallDialog.Speed.Y
                    },
                    Radius = addBallDialog.Radius,
                    Mass = addBallDialog.Mass
                };

                system.Balls.Add(newBall);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ballEditor1.Enabled = false;
            moveEnabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ballEditor1.Enabled = true;
            moveEnabled = false;
        }

        private void DrawNet(Graphics g)
        {
            var cellWidth = 25;
            var cellHeight = 25;

            using (var pen = new Pen(Color.LightGray))
            {
                for (var i = 0; i < pictureBox1.Width / cellWidth + 1; i++)
                    g.DrawLine(pen, i * cellWidth, 0, i * cellWidth, pictureBox1.Height);

                for (var i = 0; i < pictureBox1.Height / cellHeight + 1; i++)
                    g.DrawLine(pen, 0, i * cellHeight, pictureBox1.Width, i * cellHeight);
            }
        }
    }
}
