using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace LetItSnow
{
    public partial class LetItSnow : Form
    {
        private Color color = Color.Red;

        private double _rotateAngleX = 26;
        private double _rotateAngleY = 0;
        private float xRot = 65, yRot = 215;
        private double _moveX, _moveY, _moveZ = -10;
        private float size = 0;

        private void glWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right || e.KeyCode == (Keys)107 || e.KeyCode == (Keys)109)
                e.IsInputKey = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                _rotateAngleX -= 2.0f;

            if (e.KeyCode == Keys.Up)
                _rotateAngleX += 2.0f;

            if (e.KeyCode == Keys.Right)
                _rotateAngleY += 2.0f;

            if (e.KeyCode == Keys.Left)
                _rotateAngleY -= 2.0f;

            if (e.KeyCode == (Keys)107)
                size += 0.5f;

            if (e.KeyCode == (Keys)109)
                size -= 0.5f;
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        public LetItSnow()
        {
            InitializeComponent();

            glWindow.InitializeContexts();
        }

        private void LetItSnow_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut 
            Glut.glutInit();
            // инициализация режима экрана 
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_SINGLE | Glut.GLUT_DEPTH);
            // установка цвета очистки экрана (RGBA) 
            Gl.glClearColor(255, 255, 255, 1);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)glWindow.Width / glWindow.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
        }

        private void Draw()
        {
            // Before Start drawing 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glColor3ub(color.R, color.G, color.B);

            Gl.glTranslated(_moveX, _moveY, _moveZ);
            Gl.glRotated(_rotateAngleX, 1.0, 0.0, 0.0);
            Gl.glRotated(_rotateAngleY, 0.0, 1.0, 0.0);

            // Drawing
            DrawSnowMan();

            // After drawing
            Gl.glPopMatrix();
            Gl.glFlush();
            glWindow.Invalidate();
        }

        private void DrawSnowMan()
        {
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            // тело снеговика
            Gl.glTranslatef(0.0f, 0.75f, 0.0f);
            Glut.glutSolidSphere(0.75f, 20, 20);
            // голова снеговика
            Gl.glTranslatef(0.0f, 1.0f, 0.0f);
            Glut.glutSolidSphere(0.25f, 20, 20);
            // глаза снеговика
            Gl.glPushMatrix();
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glTranslatef(0.05f, 0.10f, 0.18f);
            Glut.glutSolidSphere(0.05f, 10, 10);
            Gl.glTranslatef(-0.1f, 0.0f, 0.0f);
            Glut.glutSolidSphere(0.05f, 10, 10);
            Gl.glPopMatrix();
            // нос снеговика
            Gl.glColor3f(1.0f, 0.5f, 0.5f);
            Gl.glRotatef(0.0f, 1.0f, 0.0f, 0.0f);
            Glut.glutSolidCone(0.08f, 0.5f, 10, 2);
        }
    }
}
