#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#define _USE_MATH_DEFINES

#include <GL/glew.h>
#include <GL/freeglut.h>
#include <iostream>
#include "IsoscelesTrapeze.h"
#include "Triangle.h"
#include "Square.h"

using namespace std;

#define KEY_ESCAPE 27

int Top = 50, Left = 162,
zoom = 30, left = 0, direct = 1, old = 0;
int Width, Height, oWidth = 700, oHeight = 500;
int x1 = 0, rsize = 25, xstep = 1;
char buf[19];
int i = 0;
IsoscelesTrapeze trapeze{ nullptr, Point(100, 10), 100/*H*/, 50/*bb*/,100/*tb*/};
Triangle triangle{ nullptr, Point(200,200), Point(150,100), Point(200,50)};
Triangle triangle2{ nullptr, Point(200,200), Point(150,100), Point(200,50) };
Square square{ nullptr, Point(100,50), 50, 100 };

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
	triangle2.Hide();
	glutPostRedisplay();  // перерисовываем экран
	glutTimerFunc(1, TimerFunction, 1);  //запускаем таймер заново.
}

void display() {
	glClear(GL_COLOR_BUFFER_BIT);
	triangle.Show();
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
	window();
	triangle.Rotate(30);
	triangle2.Rotate(15);
	triangle2.SetColor(Color().Red());
	glutTimerFunc(3000, TimerFunction, 1);
	glutMainLoop();
	return 0;
}