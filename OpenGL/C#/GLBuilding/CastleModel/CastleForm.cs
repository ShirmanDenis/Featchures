using System;
using System.Drawing;
using System.Windows.Forms;
using ObjParser;
using Tao.DevIl;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace CastleModel
{
    public partial class CastleForm : Form
    {
        private Color color = Color.Red;

        // флаг - загружена ли текстура 
        private bool textureIsLoad = false;
        private uint mGlTextureObject = 0;
        // имя текстуры public 
        string texture_name = "";
        // идентификатор текстуры 
        public int imageId = 0;

        private double _rotateAngleX = 20;
        private double _rotateAngleY = -2;
        private float xRot = 65, yRot = 215;
        private double _moveX, _moveY, _moveZ = -70;
        private bool _ctrlPressed;
        private float size = 0;

        private void glWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right || e.KeyCode == (Keys)107 || e.KeyCode == (Keys)109)
                e.IsInputKey = true;
        }

        private void glWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                _ctrlPressed = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                _ctrlPressed = true;

            if (e.KeyCode == Keys.Down && _ctrlPressed)
                _moveY -= 1.0;
            if (e.KeyCode == Keys.Up && _ctrlPressed)
                _moveY += 1.0;
            if (e.KeyCode == Keys.Right && _ctrlPressed)
                _moveX += 1.0;
            if (e.KeyCode == Keys.Left && _ctrlPressed)
                _moveX -= 1.0;

            if (e.KeyCode == Keys.Down && !_ctrlPressed)
                _rotateAngleX -= 2.0f;
            if (e.KeyCode == Keys.Up && !_ctrlPressed)
                _rotateAngleX += 2.0f;
            if (e.KeyCode == Keys.Right && !_ctrlPressed)
                _rotateAngleY += 2.0f;
            if (e.KeyCode == Keys.Left && !_ctrlPressed)
                _rotateAngleY -= 2.0f;
        }

        public CastleForm()
        {
            InitializeComponent();
            Height = 800;
            Width = 1124;
            glWindow.InitializeContexts();

            MouseWheel += CastleForm_MouseWheel;
        }

        private void CastleForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                _moveZ += 1;
            }
            else
            {
                _moveZ -= 1;
            }
        }

        private void CastleForm_Load(object sender, EventArgs e)
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
            Glu.gluPerspective(45, (float)glWindow.Width / glWindow.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();


            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            var ambient = new[] { 0.5882f, 0.5882f, 0.5882f };
            var diffuse = new[] { 0.5882f, 0.5882f, 0.5882f };
            var specular = new[] { 0.0f, 0.0f, 0.0f, 0.0f };
            var position = new[] { 0.0f, 3.0f, 2.0f, 0.0f };
            var lmodel_ambient = new[] { 0.4f, 0.4f, 0.4f, 1.0f };
            var local_view = new[] { 0.0f };

            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, ambient);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, diffuse);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, position);
            Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, lmodel_ambient);
            Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_LOCAL_VIEWER, local_view);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!textureIsLoad)
                LoadTexture();
            Draw();
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

            var obj = new Obj();
            obj.LoadObj("castle.obj");

            Gl.glEnable(Gl.GL_TEXTURE_2D);

            Gl.glEnable(Gl.GL_NORMALIZE);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject);

            foreach (var face in obj.FaceList)
            {
                Gl.glBegin(Gl.GL_POLYGON); // указываем поочередно вершины и текстурные координаты 
                var arrayLength = face.VertexIndexList.Length;
                
                for (int i = 0; i < arrayLength; i++)
                {
                    var vertexIndex = face.VertexIndexList[i] - 1;
                    var textureIndex = face.TextureVertexIndexList[i] - 1;
                    var normalIndex = face.NormalIndexList[i] - 1;

                    var vertex = obj.VertexList[vertexIndex];
                    var texture = obj.TextureList[textureIndex];
                    var normal = obj.NormalsList[normalIndex];

                    Gl.glNormal3d(normal.X, normal.Y, normal.Z);
                    Gl.glTexCoord2d(texture.X, texture.Y);
                    Gl.glVertex3d(vertex.X, vertex.Y, vertex.Z);                   
                }
                Gl.glEnd();
            }
            Gl.glDisable(Gl.GL_NORMALIZE);
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D); // обновляем элемент со сценой 

            Gl.glFlush();
            glWindow.Invalidate();
        }

        private void LoadTexture()
        {
            // если файл выбран - и возвращен результат OK 
            // создаем изображение с идентификатором 
            Il.ilGenImages(1, out imageId);
            // делаем изображение текущим 
            Il.ilBindImage(imageId);
            // адрес изображения полученный с помощью окна выбора файла 
            string url = "zamok.jpg";
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

        // создание текстуры в памяти openGL 
        private static uint MakeGlTexture(int Format, IntPtr pixels, int w, int h)
        {
            // идентификатор текстурного объекта 
            uint texObject;
            // генерируем текстурный объект 
            Gl.glGenTextures(1, out texObject);
            // устанавливаем режим упаковки пикселей
            Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 1);
            // создаем привязку к только что созданной текстуре 
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texObject);
            // устанавливаем режим фильтрации и повторения текстуры 
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);
            // создаем RGB или RGBA текстуру 
            switch (Format)
            {
                case Gl.GL_RGB:
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;
                case Gl.GL_RGBA:
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);
                    break;
            } // возвращаем идентификатор текстурного объекта 
            return texObject;
        }
    }
}
