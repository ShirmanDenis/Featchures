#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#define _USE_MATH_DEFINES

#include <GL/glew.h>
#include <GL/freeglut.h>
#include <iostream>
#include "IsoscelesTrapeze.h"
#include "Triangle.h"
#include "Rectangle.h"
#include "Ship.h"

using namespace std;
using namespace GLDrawing;
#define KEY_ESCAPE 27

int Width = 1000, Height = 600, i = 1;
IsoscelesTrapeze trapeze{ nullptr, Point(100, 10), 100/*H*/, 50/*bb*/,100/*tb*/};
Triangle triangle{ nullptr, Point(200,200), Point(150,100), Point(200,50)};
Triangle triangle2{ nullptr, Point(200,100), Point(150,100), Point(200,50) };
GLDrawing::Rectangle ground{ nullptr, Point(0,0), Point(Width, Height/3) };
GLDrawing::Rectangle sea{ nullptr, Point(0, Height / 3.0), Point(Width, 3*Height / 3) };
Ship ship{ nullptr, Point(200, 150) };
void window() {
	glutReshapeWindow(Width, Height);
	//glutPositionWindow(Left, Top);
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
	if (ship.Position.X == Width - 200)
		i = 0;
	if (ship.Position.X == 10)
		i = 1;
	if (i)
		ship.Move(1, 0);
	else
		ship.Move(-1, 0);
	glutPostRedisplay();  // перерисовываем экран
	glutTimerFunc(1, TimerFunction, 1);  //запускаем таймер заново.
}

void display() {
	glClear(GL_COLOR_BUFFER_BIT);

	ground.Show();
	sea.Show();
	ship.Show();
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
	sea.SetColor(Color::Turquoise());
	ground.SetColor(Color::Blue());
	glutTimerFunc(1, TimerFunction, 1);
	glutMainLoop();
	return 0;
}