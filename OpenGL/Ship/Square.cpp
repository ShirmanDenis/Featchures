#include "Square.h"
#include <exception>
#include <GL/glew.h>

void Square::SetA(double value)
{
	if (value < 0)
		throw std::exception("Value can't be less then zero");
	_a = value;
}

void Square::SetB(double value)
{
	if (value < 0)
		throw std::exception("Value can't be less then zero");
	_b = value;
}

double Square::GetA() const
{
	return _a;
}

double Square::GetB() const
{
	return _b;
}

void Square::Rotate(double angleInDegree, const Point* around, Direction direction)
{
}

void Square::Draw()
{
	glBegin(GL_POLYGON);

	if (IsVisible())
		glColor3ub(Color.R, Color.G, Color.B);
	else
		glColor4f(1, 0, 0, 0);

	auto currX = Position.X;
	auto currY = Position.Y;

	glVertex2d(currX, currY);

	glVertex2d(currX, currY += _a);
	glVertex2d(currX += _b, currY);
	glVertex2d(currX, currY -= _a);
	glVertex2d(currX -= _b, currY);

	glEnd();
}

std::vector<Point> Square::GetVertexes()
{
	return std::vector<Point>();
}

double Square::GetArea()
{
	return _a * _b;
}
