using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void simpleOpenGlControl1_Load(object sender, System.EventArgs e)
        {
            // инициализация 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода в соответствии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height); 
            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            //if ((float)AnT.Width <= (float)AnT.Height)
            //{
            //    Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);
            //}
            //else
            //{
            //    Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            //}
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity(); // настройка параметров OpenGL для визуализации 
            //Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1.0f, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0); // рисуем сферу с помощью библиотеки FreeGLUT 
            Glut.glutWireSphere(2, 32, 32);
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            // очищаем буфер цвета 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный 
            Gl.glColor3f(255, 0, 0); // активируем режим рисования линий, на основе 
                                     // последовательного соединения всех вершин в отрезки 
            Gl.glBegin(Gl.GL_LINE_STRIP); // первая вершина будет находиться в начале координат 
            Gl.glVertex2d(0, 0); // теперь в зависимости от того, как была определена проекция 
            if ((float)AnT.Width <= (float)AnT.Height)
            {
                // рисуем вторую вершину в противоположенном углу 
                Gl.glVertex2d(30.0f * (float)AnT.Height / (float)AnT.Width, 30);
            }
            else
            { // рисуем вторую вершину в противоположенном углу 
                Gl.glVertex2d(30.0f * (float)AnT.Width / (float)AnT.Height, 30);
            }
            // завершаем режим рисования 
            Gl.glEnd();
            // дожидаемся конца визуализации кадра 
            Gl.glFlush();
            // посылаем сигнал перерисовки элемента AnT. 
            AnT.Invalidate();
        }
    }
}
