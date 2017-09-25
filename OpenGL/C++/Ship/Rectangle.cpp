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
	auto arroundPoint = (around != nullptr) ? around : &Position;
	_bottomLeft.Rotate(*arroundPoint, angleInDegree, direction);
	_topRight.Rotate(*arroundPoint, angleInDegree, direction);
	_bottomRight.Rotate(*arroundPoint, angleInDegree, direction);
	_topLeft.Rotate(*arroundPoint, angleInDegree, direction);
}

void Rectangle::Draw()
{
	glBegin(GL_POLYGON);

	if (IsVisible())
		glColor3ub(Color.R, Color.G, Color.B);
	else
		glColor4f(1, 0, 0, 0);

	glVertex2d(_bottomLeft.X, _bottomLeft.Y);
	glVertex2d(_topLeft.X, _topLeft.Y);
	glVertex2d(_topRight.X, _topRight.Y);
	glVertex2d(_bottomRight.X, _bottomRight.Y);
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
