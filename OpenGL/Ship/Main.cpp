#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#define _USE_MATH_DEFINES

#include <GL/glew.h>
#include <GL/freeglut.h>
#include <iostream>
#include "IsoscelesTrapeze.cpp"

using namespace std;

#define KEY_ESCAPE 27

int Top = 50, Left = 162,
zoom = 30, left = 0, direct = 1, old = 0;
int Width, Height, oWidth = 700, oHeight = 500;
int x1 = 0, rsize = 25, xstep = 1;
char buf[19];

IsoscelesTrapeze trapeze{ nullptr, 100/*X*/, 10/*Y*/, 100/*H*/, 50/*bb*/,100/*tb*/};

void window() {
	glutReshapeWindow(oWidth, oHeight);
	glutPositionWindow(Left, Top);
}

void SetViewPort(int w, int h) {
	Width = w; Height = h;
	glViewport(0, 0, w, h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(0, w, 0, h);
	glMatrixMode(GL_MODELVIEW);
}

void TimerFunction(int value) {
	if (x1 > Width - rsize || x1 < -Width)   /// проверка на достижение края экрана по OX
		xstep = -xstep;
	x1 += xstep;   // сдвигаем координаты на заданный шаг
	if (x1 >(Width - rsize + xstep))   /// проверяем не приведёт ли это к выходу за границу экрана
		x1 = Width - rsize - 1;
	else if (x1 < -(Width + xstep))  // с другой стороны
		x1 = -Width - 1;
	glutPostRedisplay();  // перерисовываем экран
	glutTimerFunc(33, TimerFunction, 1);  //запускаем таймер заново.
}

void display() {

	glClear(GL_COLOR_BUFFER_BIT);

	trapeze.Draw();
	//glBegin(GL_QUADS); //more
	//glColor3f(0.0f, 0.0f, 1.0f);
	//glVertex2i(0, Height / 3);
	//glVertex2i(Width, Height / 3);
	//glVertex2i(Width, 0);
	//glVertex2i(0, 0);
	//glEnd();

	//glBegin(GL_QUADS); //lodka
	//glColor3f(0.3f, 0.15f, 0.0f);
	//glVertex2i(Width / 3 + x1, Height / 3 + 0.05*Height);
	//glVertex2i(Width / 3 + x1, Height / 3 - 0.05*Height);
	//glVertex2i(2 * Width / 3 + x1, Height / 3 - 0.05*Height);
	//glVertex2i(2 * Width / 3 + 0.05*Width + x1, Height / 3 + 0.05*Height);
	//glEnd();

	//glBegin(GL_TRIANGLES); //parus1
	//glColor3f(1.0, 1.0, 1.0);
	//glVertex2i(0.85*Width / 3 + x1, 1.05*(Height / 3 + 0.05*Height));
	//glColor3f(1.0, 0.8, 0.8);
	//glVertex2i(1.15*Width / 2 + x1, 1.05*(Height / 3 + 0.05*Height));
	//glColor3f(1.0, 0.8, 0.8);
	//glVertex2i(1.15*Width / 2 + x1, 1.15*(2 * Height / 3 + 0.05*Height));
	//glEnd();

	//glBegin(GL_TRIANGLES); //parus2
	//glColor3f(1.0, 1.0, 1.0);
	//glVertex2i(2.2*Width / 3 + x1, 1.05*(Height / 3 + 0.05*Height));
	//glColor3f(1.0, 0.8, 0.8);
	//glVertex2i(1.17*Width / 2 + x1, 1.05*(Height / 3 + 0.05*Height));
	//glColor3f(1.0, 0.8, 0.8);
	//glVertex2i(1.17*Width / 2 + x1, 1.1*(2 * Height / 3 + 0.05*Height));
	//glEnd();

	//glBegin(GL_TRIANGLE_FAN); //solnce
	//glColor3f(1.0, 1.0, 0.0);
	//double theta;
	//int radius = 60;
	//for (GLfloat a = 0.0f; a < 360.0f; a += 1) {
	//	theta = 2.0f * 3.14 * a / 180.0f;
	//	//	glColor4f(a / 360.0f, 1.0f, 1.0f - a / 360.0f, 1.0f);
	//	glVertex3f(radius * cos(theta) + 100, radius * sin(theta) + Height * 4 / 5, 0.0f);
	//}
	//glEnd();
	glutSwapBuffers();
}

void keys(unsigned char key, int x, int y) {
	if (key == KEY_ESCAPE) exit(0);
}

int main(int argc, char * argv[]) {
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGBA | GLUT_DEPTH | GLUT_MULTISAMPLE);
	glutCreateWindow("SHIP");
	glutReshapeFunc(SetViewPort);
	glutKeyboardFunc(keys);
	glutDisplayFunc(display);
	//window();
	//glutTimerFunc(33, TimerFunction, 1);
	glutMainLoop();
	return 0;
}