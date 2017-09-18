#include <exception>
#include "Triangle.h"
#include <GL/glew.h>

Triangle::Triangle(Figure* const parent, const Point& position, const double a, const double b, const double angle): Figure(parent, position),
                                                                                                                     _a(a),
                                                                                                                     _b(b),
                                                                                                                     _angle(angle)
{
}

Triangle::Triangle(Figure* const parent, const double a, const double b, const double angle): Figure(parent),
                                                                                              _a(a),
                                                                                              _b(b),
                                                                                              _angle(angle)
{
}

Triangle::~Triangle()
{
}

void Triangle::Draw()
{
	auto currX = Position.X;
	auto currY = Position.Y;
	auto deltaY = _a * cos(90 - (_angle * PI / 180));
	auto deltaX = sqrt(_a*_a - deltaY * deltaY);

	glBegin(GL_TRIANGLES);
	
	glVertex2d(currX += deltaX, currY += deltaY);
	glVertex2d(currX += _b - deltaX, currY -= deltaY);
	glVertex2d(Position.X, Position.Y);
	
	glEnd();
}

double Triangle::GetA() const
{
	return _a;
}

double Triangle::GetB() const
{
	return _b;
}

double Triangle::GetAngle() const
{
	return _angle;
}

void Triangle::SetA(double value)
{
	if (value < 0)
		throw std::exception("Value can't be less then zero");
	_a = value;
}

void Triangle::SetB(double value)
{
	if (value < 0)
		throw std::exception("Value can't be less then zero");
	_b = value;
}

void Triangle::SetAngleInDegree(double angleInDegree)
{
	if (angleInDegree < 0)
		throw std::exception("Value can't be less then zero");
	_angle = angleInDegree;
}

void Triangle::Rotate(double angleInDegree)
{
}

Point Triangle::GetCenter()
{
	Point center;

	return center;
}