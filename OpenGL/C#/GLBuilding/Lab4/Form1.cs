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

namespace Lab4
{
    public partial class Form1 : Form
    {
        private bool _isMouseDown = false;
        private Point _previousMouseLoaction;
        private double _zoom = 1;
        private double _rotateAngle = 45;
        private int _osX = 0, _osY = 1, _osZ = 0, rot;
        private float xRot, yRot;
        private double _moveX, _moveY, _moveZ = -8;
        private float _size = 1;
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
            if (e.KeyCode == Keys.Up)  // Стрелка вверх
                xRot -= 5.0f;

            if (e.KeyCode == Keys.Down)// Стрелка вниз
                xRot += 5.0f;

            if (e.KeyCode == Keys.Left)// Стрелка влево
                yRot -= 5.0f;

            if (e.KeyCode == Keys.Right)// Стрелка вправо
                yRot += 5.0f;
            if (e.KeyCode == (Keys) 107)
                _size += 0.1f;
            if (e.KeyCode == (Keys)109)
                _size -= 0.1f;
        }

        private Color color = Color.Red;

        public Form1()
        {
            InitializeComponent();
            
            glWindow.InitializeContexts();
            glWindow.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            Glu.gluLookAt(1,0,0,0,0,0,1,1,1);
            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity();

            Gl.glPushMatrix();

            //Gl.glTranslated(_moveX, _moveY, _moveZ);

            //Gl.glRotated(_rotateAngle, _osX, _osY, _osZ);

            Gl.glColor3ub(color.R, color.G, color.B);


            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);// Первое состояние матрицы вращения
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);// Следующее состояние

            var sizes = new float[2];
            var step = new float(); // Для определения диапазона и 
            // шага изменения размеров точки
            Gl.glGetFloatv(Gl.GL_POINT_SIZE_RANGE, sizes);// Получаем диапазон
            float curSize = sizes[0]; // Сначала установим минимальный размер
            Gl.glGetFloatv(Gl.GL_POINT_SIZE_GRANULARITY, new[]{step});  // Получаем шаг

            // Задаем три оборота в радианах
            float x, y, z, angle; // Переменные для координат и угла  
            z = -50.0f;// Задаем начальную координату z

            for (angle = 0.0f; angle <= 2.0f * Math.PI * 3.0f; angle += 0.1f)
            {
                // Вычисляем очередную точку на окружности
                x = 10.0f * (float)Math.Sin(angle);
                y = 10.0f * (float)Math.Cos(angle);

                // Задаем размер точки перед указанием примитива
                Gl.glPointSize(_size);

                // Посылаем на визуализацию каждую точку по отдельности
                Gl.glBegin(Gl.GL_POINTS);
                // Задаем точку
                Gl.glVertex3f(x, y, z);
                Gl.glEnd(); // Закончили визуализацию

                z += 0.1f; // Приближаем к зрителю
                curSize += step; // Увеличиваем размер точки
            }
            
            // Восстанавливаем матрицу вращения в исходное состояние
            Gl.glPopMatrix();
            // Восстанавливаем минимальный размер
            
            Gl.glFlush();

            glWindow.Invalidate();
        }

        private void Draw2()
        {
            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity();

            Gl.glPushMatrix();

            Gl.glTranslated(_moveX, _moveY, _moveZ);

            Gl.glRotated(_rotateAngle, _osX, _osY, _osZ);

            Gl.glColor3ub(color.R, color.G, color.B);

            Glut.glutSolidCube(2);
               
            Gl.glPopMatrix();
            // завершаем рисование
            Gl.glFlush();
            // обновляем элемент 
            glWindow.Invalidate();
        }
    }
}
