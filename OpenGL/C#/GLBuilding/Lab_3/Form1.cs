using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
namespace Lab_3
{
    public partial class Form1 : Form
    {
        // вспомогательные переменные - в них будут храниться обработанные значения, 
        // полученные при перетаскивании ползунков пользователем 
        double a, b = 0, c = -20, d = 0, zoom = 1; 
        // выбранные оси 
        int os_x = 1, os_y = 0, os_z = 0;

        private int slices = 45;
        Color color = Color.Yellow;
        // режим сеточной визуализации b
        bool Wire = true;
        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            a = trackBarX.Value / 100.0;
            labelX.Text = a.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            b = trackBarY.Value / 100.0;
            labelY.Text = b.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            c = trackBarZ.Value / 10.0;
            labelZ.Text = c.ToString(CultureInfo.InvariantCulture);
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            d = trackBarAngle.Value;
            labelAngle.Text = d.ToString(CultureInfo.InvariantCulture);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Wire = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var  result = colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            zoom = trackBarZoom.Value / 10.0;
            labelZoom.Text = zoom.ToString(CultureInfo.InvariantCulture);
        }

        private void comboBoxAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // в зависимости от выбранного режима 
            switch (comboBoxAxis.SelectedIndex) {
                // устанавливаем необходимую ось (будет использована в функции glRotate**) 
                case 0:
                {
                    os_x = 1;
                    os_y = 0;
                    os_z = 0;
                    break;
                }
                case 1:
                {
                    os_x = 0;
                    os_y = 1;
                    os_z = 0;
                    break;
                }
                case 2:
                {
                    os_x = 0;
                    os_y = 0;
                    os_z = 1;
                    break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            GlWindow.InitializeContexts();

            comboBoxAxis.SelectedIndex = 0;
            comboBoxObject.SelectedIndex = 0;
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
            Glu.gluPerspective(45, (float)GlWindow.Width / GlWindow.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity(); 
            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
//Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            var pos = new float[]{ 3, 3, 3, 1 };
            var color = new float[] { 1, 1, 1, 1 };
            var sp = new float[] { 1, 1, 1, 1 };
            var mat_specular = new float[] { 1, 1, 1, 1 };
            Gl.glEnable(Gl.GL_LIGHT3);
            Gl.glEnable(Gl.GL_LIGHT5);
            Gl.glEnable(Gl.GL_LIGHT6);

            Gl.glLightfv(Gl.GL_LIGHT3, Gl.GL_SPECULAR, sp);
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_SPECULAR, sp);
            Gl.glLightfv(Gl.GL_LIGHT6, Gl.GL_SPECULAR, sp);

            color[1] = color[2] = 0;
            Gl.glLightfv(Gl.GL_LIGHT3, Gl.GL_DIFFUSE, color);

            color[0] = 0;
            color[1] = 1;
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_DIFFUSE, color);

            color[1] = 0;
            color[2] = 1;
            Gl.glLightfv(Gl.GL_LIGHT6, Gl.GL_DIFFUSE, color);


            Gl.glLightfv(Gl.GL_LIGHT3, Gl.GL_POSITION, pos);
            pos[0] = -3;
            Gl.glLightfv(Gl.GL_LIGHT5, Gl.GL_POSITION, pos);
            pos[0] = 0; pos[1] = -3;
            Gl.glLightfv(Gl.GL_LIGHT6, Gl.GL_POSITION, pos);

            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, mat_specular);
            Gl.glMaterialf(Gl.GL_FRONT, Gl.GL_SHININESS, 128.0f);
        }

        private void Draw()
        {
            // очистка буфера цвета и буфера глубины 
            Gl.glClear( Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            // очищение текущей матрицы Gl.glLoadIdentity(); 
            // помещаем состояние матрицы в стек матриц, дальнейшие трансформации затронут только визуализацию объекта 
            Gl.glPushMatrix();
            // производим перемещение в зависимости от значений, полученных при перемещении ползунков 
            Gl.glTranslated(a, b, c);
            // поворот по установленной оси 
            Gl.glRotated(d, os_x, os_y, os_z);
            // и масштабирование объекта 
            Gl.glScaled(zoom, zoom, zoom);
            //.glColor3ub(color.R, color.G, color.B);
            // в зависимости от установленного типа объекта 
            switch (comboBoxObject.SelectedIndex) {
                // рисуем нужный объект, используя функции библиотеки GLUT 
                case 0: {
                        if (Wire)
                            // если установлен сеточный режим визуализации 
                            Glut.glutWireSphere(2, slices, slices);
                        // сеточная сфера 
                        else
                            Glut.glutSolidSphere(2, slices, slices);
                        // полигональная сфера 
                        break ;
                }
                case 1: {
                        if (Wire)
                            // если установлен сеточный режим визуализации 
                            Glut.glutWireCylinder(1, 2, slices, slices);
                        // цилиндр 
                        else
                            Glut.glutSolidCylinder(1, 2, slices, slices);
                        break;
                }
                case 2: {
                        if (Wire)
                            // если установлен сеточный режим визуализации 
                            Glut.glutWireCube(2);
                        // куб 
                        else
                            Glut.glutSolidCube(2);
                        break;
                }
                case 3: {
                        if (Wire)
                            // если установлен сеточный режим визуализации 
                            Glut.glutWireCone(2, 3, slices, slices);
                        // конус 
                        else
                            Glut.glutSolidCone(2, 3, slices, slices);
                        break;
                }
                case 4: {
                        if (Wire)
                            // если установлен сеточный режим визуализации 
                            Glut.glutWireTorus(0.2, 2.2, slices, slices);
                        // тор 
                        else
                            Glut.glutSolidTorus(0.2, 2.2, slices, slices);
                        break;
                }
                case 5:{
                    if (Wire)
                        // если установлен сеточный режим визуализации 
                        Glut.glutWireOctahedron();
                    // тор 
                    else
                        Glut.glutSolidOctahedron();
                    break;
                }
                case 6:
                {
                    if (Wire)
                        // если установлен сеточный режим визуализации 
                        Glut.glutWireDodecahedron();
                    // тор 
                    else
                        Glut.glutSolidDodecahedron();
                    break;
                }
                case 7:
                {
                    if (Wire)
                        // если установлен сеточный режим визуализации 
                        Glut.glutWireTetrahedron();
                    // тор 
                    else
                        Glut.glutSolidTetrahedron();
                    break;
                }
                case 8:
                {
                    if (Wire)
                        // если установлен сеточный режим визуализации 
                        Glut.glutWireIcosahedron();
                    // тор 
                    else
                        Glut.glutSolidIcosahedron();
                    break;
                }
            } 
            // возвращаем состояние матрицы 
            Gl.glPopMatrix();
            // завершаем рисование
            Gl.glFlush();
            // обновляем элемент 
            GlWindow.Invalidate(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
