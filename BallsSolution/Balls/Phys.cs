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
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            using (var graph = Graphics.FromImage(canvas))
            {
                graph.Clear(Color.AliceBlue);

                system.DrawSystem(graph);
            }                

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
            if (!renderTimer.Enabled)
                renderTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (renderTimer.Enabled)
                renderTimer.Stop();
        }
    }
}
