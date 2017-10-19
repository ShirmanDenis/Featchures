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
using Tao.DevIl;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private bool _isMouseDown = false;
        private Point _previousMouseLoaction;
        private double _zoom = 1;
        private double _rotateAngle = 45;
        private int _osX = 0, _osY = 1, _osZ = 0, rot;

        private double _moveX, _moveY, _moveZ = -8;

        private Color color = Color.Blue;
        // флаг - загружена ли текстура 
        private bool textureIsLoad = false;
        private uint mGlTextureObject = 0;
        // имя текстуры public 
        string texture_name = "";
        // идентификатор текстуры 
        public int imageId = 0;
        public Form1()
        {
            InitializeComponent();

            GlWindow.InitializeContexts();
            GlWindow.MouseWheel += GlWindow_MouseWheel;
        }

        private void GlWindow_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                _moveZ += 0.05;
            else
                _moveZ -= 0.05;
        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
        }

        private void window_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                _rotateAngle += (e.Location.X - _previousMouseLoaction.X) / 100.0;
            }
            else
            {
                _previousMouseLoaction = e.Location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTexture();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut 
            Glut.glutInit();
            // инициализация режима экрана 
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_SINGLE | Glut.GLUT_DEPTH);
            // установка цвета очистки экрана (RGBA) 
            Gl.glClearColor(255, 255, 255, 1);

            // инициализация библиотеки openIL 
            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float) GlWindow.Width / GlWindow.Height, 0.1, 200);
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
            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity(); 

            Gl.glPushMatrix();

            Gl.glTranslated(_moveX, _moveY, _moveZ);

            Gl.glRotated(_rotateAngle, _osX, _osY, _osZ);

            Gl.glColor3ub(color.R, color.G, color.B);

            // если текстура загружена 
            if (textureIsLoad)
            {
                // увеличиваем угол поворота 
                rot++;
                // корректируем угол 
                if (rot > 360) rot = 0;
                // очистка буфера цвета и буфера глубины 
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                Gl.glClearColor(255, 255, 255, 1);
                // очищение текущей матрицы 
                Gl.glLoadIdentity();
                // включаем режим текстурирования 
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                // включаем режим текстурирования, указывая идентификатор 
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject);
                // сохраняем состояние матрицы 
                Gl.glPushMatrix();
                // выполняем перемещение для более наглядного представления сцены 
                Gl.glTranslated(0, -1, -5);
                // реализуем поворот объекта 
                Gl.glRotated(rot, 0, 1, 0); // отрисовываем полигон 
                Gl.glBegin(Gl.GL_QUADS); // указываем поочередно вершины и текстурные координаты 
                Gl.glVertex3d(1, 1, 0);
                Gl.glTexCoord2f(0, 0);
                Gl.glVertex3d(1, 0, 0);
                Gl.glTexCoord2f(1, 0);
                Gl.glVertex3d(0, 0, 0);
                Gl.glTexCoord2f(1, 1);
                Gl.glVertex3d(0, 1, 0);
                Gl.glTexCoord2f(0, 1);
                // завершаем отрисовку 
                Gl.glEnd();
                // возвращаем матрицу 
                Gl.glPopMatrix(); // отключаем режим текстурирования 
                Gl.glDisable(Gl.GL_TEXTURE_2D); // обновляем элемент со сценой 
                GlWindow.Invalidate();

                Gl.glPopMatrix();
                // завершаем рисование
                Gl.glFlush();
                // обновляем элемент 
                GlWindow.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        private void LoadTexture()
        {
            // открываем окно выбора файла 
            var res = openFileDialog1.ShowDialog();
            // если файл выбран - и возвращен результат OK 
            if (res == DialogResult.OK)
            {
                // создаем изображение с идентификатором 
                Il.ilGenImages(1, out imageId);
                // делаем изображение текущим 
                Il.ilBindImage(imageId);
                // адрес изображения полученный с помощью окна выбора файла 
                string url = openFileDialog1.FileName;
                // пробуем загрузить изображение 
                if (Il.ilLoadImage(url))
                {
                    // если загрузка прошла успешно 
                    // сохраняем размеры изображения 
                    int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
                    int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);
                    // определяем число бит на пиксель 
                    int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);
                    switch (bitspp)
                    {
                        // создаем текстуру, используя режим GL_RGB или GL_RGBA 
                        case 24:
                            mGlTextureObject = MakeGlTexture(Gl.GL_RGB, Il.ilGetData(), width, height);
                            break;
                        case 32:
                            mGlTextureObject = MakeGlTexture(Gl.GL_RGBA, Il.ilGetData(), width, height);
                            break;
                    }
                    // активируем флаг, сигнализирующий загрузку текстуры 
                    textureIsLoad = true;
                    // очищаем память 
                    Il.ilDeleteImages(1, ref imageId);
                }
            }
        }

        // создание текстуры в памяти openGL 
        private static uint MakeGlTexture( int Format, IntPtr pixels, int w, int h) {
            // идентификатор текстурного объекта 
            uint texObject;
            // генерируем текстурный объект 
            Gl.glGenTextures(1, out texObject);
            // устанавливаем режим упаковки пикселей
            Gl.glPixelStorei( Gl.GL_UNPACK_ALIGNMENT, 1);
            // создаем привязку к только что созданной текстуре 
            Gl.glBindTexture( Gl.GL_TEXTURE_2D, texObject);
            // устанавливаем режим фильтрации и повторения текстуры 
            Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri( Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexEnvf( Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);
            // создаем RGB или RGBA текстуру 
            switch (Format)
            {
                case Gl.GL_RGB:
                    Gl.glTexImage2D( Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;
                case Gl.GL_RGBA:
                    Gl.glTexImage2D( Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;
            } // возвращаем идентификатор текстурного объекта 
            return texObject;
        } 
    }
}
