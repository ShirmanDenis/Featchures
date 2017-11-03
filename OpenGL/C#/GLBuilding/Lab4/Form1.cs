using System;
using System.Drawing;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Lab4
{
    public enum FigureToDraw
    {
        Cone,
        Star,
        LineStipple,
        PointsZ,
        LinesW,
        PolygonStipple
    }

    public partial class Form1 : Form
    {
        private FigureToDraw _currentFigure = FigureToDraw.Cone;
        private Color color = Color.Red;

        private double _rotateAngleX = -110;
        private double _rotateAngleY = 0;
        private float xRot = 65, yRot = 215;
        private double _moveX, _moveY, _moveZ = -120;
        private float size = 0;

        private bool _isSelection;
        private bool _isDepth;
        private bool _isBackWall;
        private int _isEdge = 1;

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

            if (e.KeyCode == (Keys) 107)
                size += 0.5f;

            if (e.KeyCode == (Keys)109)
                size -= 0.5f;
        }

        private void glWindow_MouseClick(object sender, MouseEventArgs e)
        {
            var calculatedLocation = new Point
            {
                X = e.X + Location.X + 20,
                Y = e.Y + Location.Y + 20
            };
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu.Show(calculatedLocation);
            }
        }
        private void contextCone_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.Cone;
        }
        private void MenuItemPointsZ_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.PointsZ;
        }
        private void MenuItemStar_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.Star;
        }
        private void MenuItemLinesStipple_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.LineStipple;
        }

        public Form1()
        {
            InitializeComponent();

            glWindow.InitializeContexts();
        }

        private void MenuItemDepth_Click(object sender, EventArgs e)
        {
            _isDepth = !_isDepth;

            MenuItemDepth.BackColor = _isDepth ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void MenuItemBackWall_Click(object sender, EventArgs e)
        {
            _isBackWall = !_isBackWall;

            MenuItemBackWall.BackColor = _isBackWall ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void MenuItemSelection_Click(object sender, EventArgs e)
        {
            _isSelection = !_isSelection;

            MenuItemSelection.BackColor = _isSelection ? SystemColors.ActiveCaption : SystemColors.Control;
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

        private void MenuItemEdges_Click(object sender, EventArgs e)
        {
            _isEdge = _isEdge == 1 ? 0 : 1;

            MenuItemEdges.BackColor = _isEdge == 1 ? SystemColors.ActiveCaption : SystemColors.Control;
        }

        private void Draw()
        {
            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glLoadIdentity();

            Gl.glPushMatrix();

            Gl.glColor3ub(color.R, color.G, color.B);

            Gl.glTranslated(_moveX, _moveY, _moveZ);
            Gl.glRotated(_rotateAngleX, 1.0, 0.0, 0.0);
            Gl.glRotated(_rotateAngleY, 0.0, 1.0, 0.0);

            switch (_currentFigure)
            {
                case FigureToDraw.Cone:
                    DrawCone();
                    break;
                case FigureToDraw.Star:
                    DrawStar();
                    break;
                case FigureToDraw.LineStipple:
                    DrawLineStipple();
                    break;
                case FigureToDraw.PointsZ:
                    DrawPointsZ();
                    break;
                case FigureToDraw.LinesW:
                    DrawLinesW();
                    break;
                case FigureToDraw.PolygonStipple:
                    DrawPolygonStipple();
                    break;
            }

            Gl.glPopMatrix();

            Gl.glFlush();

            glWindow.Invalidate();
        }

        private void DrawCone()
        {
            float x, y, angle;    // Переменные для координат и угла
            bool iColor = false;     // Флаг переключения цвета

            // Устанавливаем неструктурированный цвет модели затенения
            Gl.glShadeModel(Gl.GL_FLAT);

            // Устанавливаем направление обхода по часовой стрелке
            Gl.glFrontFace(Gl.GL_CW);

            //// Очистить окно и буфер глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            // Включить/Выключить отбор
            if (_isSelection)
                Gl.glEnable(Gl.GL_CULL_FACE);
            else
                Gl.glDisable(Gl.GL_CULL_FACE);

            // Включить/Выключить глубину
            if (_isDepth)
                Gl.glEnable(Gl.GL_DEPTH_TEST);
            else
                Gl.glDisable(Gl.GL_DEPTH_TEST);

            // Включить/Выключить каркас задней стенки
            if (_isBackWall)
                Gl.glPolygonMode(Gl.GL_BACK, Gl.GL_LINE);
            else
                Gl.glPolygonMode(Gl.GL_BACK, Gl.GL_FILL);

            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Выполнить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);// Новое состояние матрицы вращения
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);// Следующее новое состояние

            //************  Рисовать конус  ***********************************
            // Рисовать веер треугольников
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            // Устанавливаем первую точку - вершину конуса ближе к наблюдателю
            Gl.glVertex3f(0.0f, 0.0f, 50.0f);

            // Проходим оборот в плоскости x0y
            for (angle = 0.0f; angle <= 3.0f * Math.PI; angle += (float)Math.PI / 8.0f)
            {
                // Вычисляем очередную точку на окружности
                x = 20.0f * (float)Math.Sin(angle);
                y = 20.0f * (float)Math.Cos(angle);

                // Чередуем цвета
                if (iColor) // Деление по модулю
                    Gl.glColor3f(0.0f, 1.0f, 0.0f);    // Зеленый
                else
                    Gl.glColor3f(0xFF, 0xFF, 0x00); // Желтый

                iColor = !iColor; // Для переключения цвета

                // Установливаем вычисленную точку на плоскости x0y
                Gl.glVertex2f(x, y);
            }

            Gl.glEnd(); // Рисуем веер, имитирующий конус

            //***********  Рисовать основание конуса  *************************
            // Начинаем строить новый веер в плоскости x0y
            // Имитирующий основание конуса в начале координат

            Gl.glBegin(Gl.GL_TRIANGLE_FAN);
            // Устанавливаем первую точку центра основания при z=0
            Gl.glVertex2f(0.0f, 0.0f);

            // Проходим оборот в плоскости x0y
            for (angle = 0.0f; angle <= 3.0f * Math.PI; angle += (float)Math.PI / 10.0f)
            {
                // Вычисляем очередную точку на окружности
                x = 20.0f * (float)Math.Sin(angle);
                y = 20.0f * (float)Math.Cos(angle);

                // Чередуем цвета
                if (!(iColor))  // Деление по модулю
                    Gl.glColor3f(0.0f, 0.0f, 1.0f);    // Синий
                else
                    Gl.glColor3f(1.0f, 0.0f, 0.0f);    // Красный

                iColor = !iColor; // Для переключения цвета

                // Установливаем вычисленную точку на плоскости x0y
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd(); // Рисуем веер, имитирующий основание

            // Восстанавливаем измененные состояния в исходные значения
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_CULL_FACE);
            Gl.glDisable(Gl.GL_DEPTH_TEST);
            Gl.glPolygonMode(Gl.GL_BACK, Gl.GL_FILL);
            Gl.glColor3f(0.0f, 1.0f, 0.0f);	// Зеленый
        }

        private void DrawStar()
        {
            // Очистить окно просмотра
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // Включить каркасный режим для обеих сторон звезды
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);

            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Выполнить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);

            //************  Рисовать внутренние контуры звезды  *************
            // Рисовать веер треугольников
            Gl.glBegin(Gl.GL_TRIANGLES);
            // Устанавливаем переключатель метки сторон
            Gl.glEdgeFlag(_isEdge);

            // Устанавливаем вершины
            Gl.glVertex2f(0.0f, 0.0f); // Центр звезды
            Gl.glVertex2f(-18.0f, 26.0f);
            Gl.glVertex2f(18.0f, 26.0f);

            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(18.0f, 26.0f);
            Gl.glVertex2f(30.0f, -10.0f);

            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(30.0f, -10.0f);
            Gl.glVertex2f(0.0f, -32.0f);

            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(0.0f, -32.0f);
            Gl.glVertex2f(-30.0f, -10.0f);

            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(-30.0f, -10.0f);
            Gl.glVertex2f(-18.0f, 26.0f);
            Gl.glEnd();

            //***********  Рисовать внешние треугольники звезды **************
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glEdgeFlag(1);
            Gl.glVertex2f(-18.0f, 26.0f);
            Gl.glVertex2f(0.0f, 80.0f); Gl.glEdgeFlag(0);
            Gl.glVertex2f(18.0f, 26.0f);

            Gl.glEdgeFlag(1);
            Gl.glVertex2f(18.0f, 26.0f);
            Gl.glVertex2f(80.0f, 26.0f); Gl.glEdgeFlag(0);
            Gl.glVertex2f(30.0f, -10.0f);

            Gl.glEdgeFlag(1);
            Gl.glVertex2f(30.0f, -10.0f);
            Gl.glVertex2f(50.0f, -68.0f); Gl.glEdgeFlag(0);
            Gl.glVertex2f(0.0f, -32.0f);

            Gl.glEdgeFlag(1);
            Gl.glVertex2f(0.0f, -32.0f);
            Gl.glVertex2f(-50.0f, -68.0f); Gl.glEdgeFlag(0);
            Gl.glVertex2f(-30.0f, -10.0f);

            Gl.glEdgeFlag(1);
            Gl.glVertex2f(-30.0f, -10.0f);
            Gl.glVertex2f(-80.0f, 26.0f); Gl.glEdgeFlag(0);
            Gl.glVertex2f(-18.0f, 26.0f);
            Gl.glEnd();

            // Восстанавливаем измененные состояния в исходные значения
            Gl.glPopMatrix();
            Gl.glPolygonMode(Gl.GL_BACK, Gl.GL_FILL);
        }

        private void MenuItemLinesW_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.LinesW;
        }

        private void DrawLineStipple()
        {
            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Настроить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);// Первое состояние матрицы вращения
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);// Следующее состояние

            var  sizes = new float[2]; // Емкость для определения диапазона ширины линий
            Gl.glGetFloatv(Gl.GL_LINE_WIDTH_RANGE, sizes);// Извлекаем диапазон
            // Устанавливаем минимальный размер ширины линий
            Gl.glLineWidth(sizes[0]);

            // Устанавливаем начальные параметры фактуры
            int factor = 1;           // Начальный множитель шаблона
            ushort pattern = 0x5555;  // Шестнадцатиричное представление шаблона

            // Включаем режим фактуры
            Gl.glEnable(Gl.GL_LINE_STIPPLE);

            // Пошаговый проход по оси y с шагом 20 единиц снизу вверх
            // Получится 10 линий по размеру отсекающего куба в плоскости z = 0
            for (float y = -90.0f; y <= 90.0f; y += 20.0f)
            {
                // Устанавливаем множитель и шаблон
                Gl.glLineStipple(factor, pattern);

                // Посылаем на визуализацию каждую линию по отдельности
                Gl.glBegin(Gl.GL_LINES);
                // Задаем два конца линии в плоскости z = 0
                Gl.glVertex2f(-90.0f, y);
                Gl.glVertex2f(90.0f, y);
                Gl.glEnd(); // Закончили визуализацию

                factor += 3;    // Увеличиваем множитель шаблона
            }

            // Восстанавливаем матрицу вращения в исходное состояние
            Gl.glPopMatrix();

            // Отключаем режим фактуры
            Gl.glDisable(Gl.GL_LINE_STIPPLE);
        }

        private void MenuItemPloygonStipple_Click(object sender, EventArgs e)
        {
            _currentFigure = FigureToDraw.PolygonStipple;
        }

        private void DrawPointsZ()
        {
            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Настроить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);// Первое состояние матрицы вращения
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);// Следующее состояние

            var sizes = new float[2];
            var step = 0.0f; // Для определения диапазона и 
            // шага изменения размеров точки
            Gl.glGetFloatv(Gl.GL_POINT_SIZE_RANGE, sizes);// Получаем диапазон
            var curSize = sizes[0]; // Сначала установим минимальный размер
            Gl.glGetFloatv(Gl.GL_POINT_SIZE_GRANULARITY, sizes);  // Получаем шаг

            // Задаем три оборота в радианах
            float x, y, z, angle; // Переменные для координат и угла	
            z = -50.0f;// Задаем начальную координату z

            for (angle = 0.0f; angle <= 2.0f * Math.PI * 3.0f; angle += 0.1f)
            {
                // Вычисляем очередную точку на окружности
                x = 50.0f * (float)Math.Sin(angle);
                y = 50.0f * (float)Math.Cos(angle);

                // Задаем размер точки перед указанием примитива
                Gl.glPointSize(size);

                // Посылаем на визуализацию каждую точку по отдельности
                Gl.glBegin(Gl.GL_POINTS);
                // Задаем точку
                Gl.glVertex3f(x, y, z);
                Gl.glEnd(); // Закончили визуализацию

                z += 0.5f; // Приближаем к зрителю
                curSize += step; // Увеличиваем размер точки
            }

            // Восстанавливаем матрицу вращения в исходное состояние
            Gl.glPopMatrix();

            // Восстанавливаем минимальный размер
            Gl.glPointSize(sizes[0]);
        }

        private void DrawLinesW()
        {
            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Настроить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(xRot, 1.0f, 0.0f, 0.0f);// Первое состояние матрицы вращения
            Gl.glRotatef(yRot, 0.0f, 1.0f, 0.0f);// Следующее состояние

            var sizes = new float[2];
            var step = new float[2]; // Для определения диапазона и 
            // шага изменения ширины линий
            Gl.glGetFloatv(Gl.GL_LINE_WIDTH_RANGE, sizes);// Получаем диапазон
            var curSize = sizes[0]; // Сначала установим минимальный размер
            Gl.glGetFloatv(Gl.GL_LINE_WIDTH_GRANULARITY, step);  // Получаем шаг

            float y; // Переменная для координаты y

            // Пошаговый проход по оси y с шагом 20 единиц снизу вверх
            // Получится 10 линий по размеру отсекающего куба в плоскости z = 0
            for (y = -90.0f; y <= 90.0f; y += 20.0f)
            {
                // Задаем ширину линии
                Gl.glLineWidth(curSize);

                // Посылаем на визуализацию каждую линию по отдельности
                Gl.glBegin(Gl.GL_LINES);
                // Задаем два конца линии в плоскости z = 0
                Gl.glVertex2f(-90.0f, y);
                Gl.glVertex2f(90.0f, y);
                Gl.glEnd(); // Закончили визуализацию

                curSize += 3.0f * step[0]; // Увеличиваем ширину линии 
                // с помощью весового коэффициента
            }

            // Восстанавливаем матрицу вращения в исходное состояние
            Gl.glPopMatrix();

            // Восстанавливаем минимальный размер ширины
            Gl.glLineWidth(sizes[0]);
        }

        private void DrawPolygonStipple()
        {
            var fire = new byte[]
            {
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0xc0,
                0x00, 0x00, 0x01, 0xf0,
                0x00, 0x00, 0x07, 0xf0,
                0x0f, 0x00, 0x1f, 0xe0,
                0x1f, 0x80, 0x1f, 0xc0,
                0x0f, 0xc0, 0x3f, 0x80,
                0x07, 0xe0, 0x7e, 0x00,
                0x03, 0xf0, 0xff, 0x80,
                0x03, 0xf5, 0xff, 0xe0,
                0x07, 0xfd, 0xff, 0xf8,
                0x1f, 0xfc, 0xff, 0xe8,
                0xff, 0xe3, 0xbf, 0x70,
                0xde, 0x80, 0xb7, 0x00,
                0x71, 0x10, 0x4a, 0x80,
                0x03, 0x10, 0x4e, 0x40,
                0x02, 0x88, 0x8c, 0x20,
                0x05, 0x05, 0x04, 0x40,
                0x02, 0x82, 0x14, 0x40,
                0x02, 0x40, 0x10, 0x80,
                0x02, 0x64, 0x1a, 0x80,
                0x00, 0x92, 0x29, 0x00,
                0x00, 0xb0, 0x48, 0x00,
                0x00, 0xc8, 0x90, 0x00,
                0x00, 0x85, 0x10, 0x00,
                0x00, 0x03, 0x00, 0x00,
                0x00, 0x00, 0x10, 0x00
            };


            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // Запомнить первоначальное состояние матрицы вращения
            Gl.glPushMatrix();

            // Настроить два последовательных поворота
            // для будущей визуализации сцены
            Gl.glRotatef(250, 1.0f, 0.0f, 0.0f);// Первое состояние матрицы вращения
            Gl.glRotatef(0, 0.0f, 1.0f, 0.0f);// Следующее состояние

            // Включить красный цвет рисования
            Gl.glColor3f(1.0f, 0.0f, 0.0f);

            // Включить фактуру при заполнении полигонов
            Gl.glEnable(Gl.GL_POLYGON_STIPPLE);

            // Адресовать битовую маску костра для фактуры
            Gl.glPolygonStipple(fire);

            // Нарисовать полигон в форме дорожного знака
            // "Движение без остановки запрещено",
            // закрашенного по маске костра красным цветом
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(-20.0f, 50.0f);
            Gl.glVertex2f(20.0f, 50.0f);
            Gl.glVertex2f(50.0f, 20.0f);
            Gl.glVertex2f(50.0f, -20.0f);
            Gl.glVertex2f(20.0f, -50.0f);
            Gl.glVertex2f(-20.0f, -50.0f);
            Gl.glVertex2f(-50.0f, -20.0f);
            Gl.glVertex2f(-50.0f, 20.0f);
            Gl.glEnd();

            Gl.glColor3f(0.0f, 1.0f, 0.0f); // Восстановить цвет рисования зеленый

            // Выключить фактуру при заполнении полигонов
            Gl.glDisable(Gl.GL_POLYGON_STIPPLE);

            // Восстановить матрицу вращения в исходное состояние
            Gl.glPopMatrix();
        }
    }
}
