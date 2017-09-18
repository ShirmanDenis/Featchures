#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#define _USE_MATH_DEFINES

#include <GL/glew.h>
#include <GL/freeglut.h>
#include <iostream>
#include "IsoscelesTrapeze.h"
#include "Triangle.h"

using namespace std;

#define KEY_ESCAPE 27

int Top = 50, Left = 162,
zoom = 30, left = 0, direct = 1, old = 0;
int Width, Height, oWidth = 700, oHeight = 500;
int x1 = 0, rsize = 25, xstep = 1;
char buf[19];

IsoscelesTrapeze trapeze{ nullptr, Point(100, 10), 100/*H*/, 50/*bb*/,100/*tb*/};
Triangle triangle{ nullptr, Point(100,10), 50, 100, 50 };

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

	triangle.Draw();

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