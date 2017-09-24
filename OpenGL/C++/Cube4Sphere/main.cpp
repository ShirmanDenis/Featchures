#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

#define _USE_MATH_DEFINES

#include <GL/glew.h>
#include <GL/freeglut.h>
#include <iostream>

void display();
void specialKeys();

// ----------------------------------------------------------
// Global Variables
// ----------------------------------------------------------
int slices = 3;
double rotate_y = 45;
double rotate_x = 45;

void drawCube()
{
	//Multi-colored side - FRONT
	glBegin(GL_LINE_LOOP);
	glColor3f(1.0, 1.0, 0);
	glVertex3f(0.5, -0.5, -0.5);
	glVertex3f(0.5, 0.5, -0.5);
	glVertex3f(-0.5, 0.5, -0.5);
	glVertex3f(-0.5, -0.5, -0.5);

	glEnd();

	// Black side - BACK
	glBegin(GL_LINE_LOOP);
	glColor3ub(0, 0, 0);
	glVertex3f(0.5, -0.5, 0.5);
	glVertex3f(0.5, 0.5, 0.5);
	glVertex3f(-0.5, 0.5, 0.5);
	glVertex3f(-0.5, -0.5, 0.5);
	glEnd();

	// Purple side - RIGHT
	glBegin(GL_LINE_LOOP);
	glColor3f(1.0, 0.0, 1.0);
	glVertex3f(0.5, -0.5, -0.5);
	glVertex3f(0.5, 0.5, -0.5);
	glVertex3f(0.5, 0.5, 0.5);
	glVertex3f(0.5, -0.5, 0.5);
	glEnd();

	// Green side - LEFT
	glBegin(GL_LINE_LOOP);
	glColor3f(0.0, 1.0, 0.0);
	glVertex3f(-0.5, -0.5, 0.5);
	glVertex3f(-0.5, 0.5, 0.5);
	glVertex3f(-0.5, 0.5, -0.5);
	glVertex3f(-0.5, -0.5, -0.5);
	glEnd();

	// Blue side - TOP
	glBegin(GL_LINE_LOOP);
	glColor3f(0.0, 0.0, 1.0);
	glVertex3f(0.5, 0.5, 0.5);
	glVertex3f(0.5, 0.5, -0.5);
	glVertex3f(-0.5, 0.5, -0.5);
	glVertex3f(-0.5, 0.5, 0.5);
	glEnd();

	// Red side - BOTTOM
	glBegin(GL_LINE_LOOP);
	glColor3f(1.0, 0.0, 0.0);
	glVertex3f(0.5, -0.5, -0.5);
	glVertex3f(0.5, -0.5, 0.5);
	glVertex3f(-0.5, -0.5, 0.5);
	glVertex3f(-0.5, -0.5, -0.5);
	glEnd();
}

void drawNet(int delimterCount)
{
	glColor3ub(0, 0, 0);
	auto cellsize = 1. / delimterCount;
	glBegin(GL_LINES);
	for (size_t i = 0; i < delimterCount; i++)
	{
		// BACK - Vertical
		glVertex3d(-0.5 + i*cellsize, 0.5, -0.5);
		glVertex3d(-0.5 + i*cellsize, -0.5, -0.5);
		// BACK - Horizont
		glVertex3d(-0.5, 0.5 - i*cellsize, -0.5);
		glVertex3d(0.5, 0.5 - i*cellsize, -0.5);
		// FRONT - Vertical
		glVertex3d(-0.5 + i*cellsize, 0.5, 0.5);
		glVertex3d(-0.5 + i*cellsize, -0.5, 0.5);
		// FRONT - Horizont
		glVertex3d(-0.5, 0.5 - i*cellsize, 0.5);
		glVertex3d(0.5, 0.5 - i*cellsize, 0.5);
		// LEFT - Vertical
		glVertex3d(-0.5, 0.5, 0.5 - i*cellsize);
		glVertex3d(-0.5, -0.5, 0.5 - i*cellsize);
		// LEFT - Horizont
		glVertex3d(-0.5, 0.5 - i*cellsize, 0.5);
		glVertex3d(-0.5, 0.5 - i*cellsize, -0.5);
		// RIGHT - Vertical
		glVertex3d(0.5, 0.5, 0.5 - i*cellsize);
		glVertex3d(0.5, -0.5, 0.5 - i*cellsize);
		// RIGHT - Horizont
		glVertex3d(0.5, 0.5 - i*cellsize, 0.5);
		glVertex3d(0.5, 0.5 - i*cellsize, -0.5);
		// TOP - Vertical
		glVertex3d(0.5, 0.5, 0.5 - i*cellsize);
		glVertex3d(-0.5, 0.5, 0.5 - i*cellsize);
		// TOP - Horizont
		glVertex3d(0.5 - i*cellsize, 0.5, 0.5);
		glVertex3d(0.5 - i*cellsize, 0.5, -0.5);
		// BOT - Vertical
		glVertex3d(0.5, -0.5, 0.5 - i*cellsize);
		glVertex3d(-0.5, -0.5, 0.5 - i*cellsize);
		// BOT - Horizont
		glVertex3d(0.5 - i*cellsize, -0.5, 0.5);
		glVertex3d(0.5 - i*cellsize, -0.5, -0.5);
	}
	glEnd();
}

void window() {
	glutReshapeWindow(1000, 800);
	glutPositionWindow(0, 0);
}

void drawSphere(double x, double y, double z, double rad, int slices, int stacks)
{
	glPushMatrix();
	glTranslated(x, y, z);
	glColor3ub(255, 255, 0);
	glutWireSphere(rad, slices, stacks);
	glPopMatrix();
}

// ----------------------------------------------------------
// display() Callback function
// ----------------------------------------------------------
void display() {
	//  Clear screen and Z-buffer
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	glClearColor(1, 1, 1, 0);
	// Reset transformations
	glLoadIdentity();

	// Rotate when user changes rotate_x and rotate_y
	glRotatef(rotate_x, 1.0, 0.0, 0.0);
	glRotatef(rotate_y, 0.0, 1.0, 0.0);	

	drawCube();
	drawNet(3);
	auto halfOfCellSize = 1. / slices * 0.5;
	drawSphere(0.5 + halfOfCellSize, 0.5 + halfOfCellSize, 0.5 + halfOfCellSize, halfOfCellSize, 10, 10);
	glFlush();
	glutSwapBuffers();
}

// ----------------------------------------------------------
// specialKeys() Callback Function
// ----------------------------------------------------------
void specialKeys(int key, int x, int y) {

	//  Right arrow - increase rotation by 5 degree
	if (key == GLUT_KEY_RIGHT)
		rotate_y += 5;

	//  Left arrow - decrease rotation by 5 degree
	else if (key == GLUT_KEY_LEFT)
		rotate_y -= 5;

	else if (key == GLUT_KEY_UP)
		rotate_x += 5;

	else if (key == GLUT_KEY_DOWN)
		rotate_x -= 5;

	//  Request display update
	glutPostRedisplay();

}

// ----------------------------------------------------------
// main() function
// ----------------------------------------------------------
int main(int argc, char* argv[]) {

	//  Initialize GLUT and process user parameters
	glutInit(&argc, argv);

	//  Request double buffered true color window with Z-buffer
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
	// Create window
	glutCreateWindow("Awesome Cube");

	//  Enable Z-buffer depth test
	glEnable(GL_DEPTH_TEST);

	// Callback functions
	glutDisplayFunc(display);
	glutSpecialFunc(specialKeys);
	window();
	//  Pass control to GLUT for events
	glutMainLoop();
	return 0;

}