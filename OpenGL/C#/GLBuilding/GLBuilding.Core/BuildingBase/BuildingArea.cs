using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLBuilding.Core.BuildingBase;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace GLBuilding.Core
{
    public class BuildingArea
    {
        public BuildingArea(BuildContext context)
        {
            Context = context;

            InitArea(Context.ClearColor, Context.Width, Context.Height);
        }

        #region Properties

        public BuildContext Context { get; }

        #endregion

        public void DrawSphere()
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
        }

        private void InitArea(Color clearColor, int Width, int Height)
        {
            // инициализация 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(clearColor.R, clearColor.G, clearColor.B, 0);

            Gl.glViewport(0, 0, Width, Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluPerspective(45, (float)Width / Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity(); 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }
    }
}
