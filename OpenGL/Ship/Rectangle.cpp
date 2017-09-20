#include "Rectangle.h"
#include <exception>
#include <GL/glew.h>
using namespace GLDrawing;
void Rectangle::SetBottomLeft(Point value)
{
	_bottomLeft = value;
}

void Rectangle::SetTopRight(Point value)
{
	_topRight = value;
}

Point Rectangle::GetBottomLeft() const
{
	return _bottomLeft;
}

Point Rectangle::GetTopRight() const
{
	return _topRight;
}

void Rectangle::Rotate(double angleInDegree, const Point* around, Direction direction)
{
	Point squareCenter;
	squareCenter.X = _topRight.X - _bottomLeft.X;
	squareCenter.Y = _topRight.Y - _bottomLeft.Y;
	auto arroundPoint = (around != nullptr) ? around : &squareCenter;
	_bottomLeft.Rotate(arroundPoint, angleInDegree, direction);
	_topRight.Rotate(arroundPoint, angleInDegree, direction);
}

void Rectangle::Draw()
{
	glBegin(GL_POLYGON);

	if (IsVisible())
		glColor3ub(Color.R, Color.G, Color.B);
	else
		glColor4f(1, 0, 0, 0);

	auto currX = Position.X;
	auto currY = Position.Y;
	auto deltaY = _topRight.Y - _bottomLeft.Y;
	auto deltaX = _topRight.X - _bottomLeft.X;
	glVertex2d(currX, currY);
	glVertex2d(currX, currY += deltaY);
	glVertex2d(currX += deltaX, currY);
	glVertex2d(currX, currY -= deltaY);
	glVertex2d(_bottomLeft.X, _bottomLeft.Y);
	glEnd();
}

std::vector<Point> Rectangle::GetVertexes()
{
	return std::vector<Point>();
}

double Rectangle::GetArea()
{
	return 0;
}
