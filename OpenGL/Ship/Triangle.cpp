#include <exception>
#include "Triangle.h"
#include <GL/glew.h>

Triangle::Triangle(Figure* const parent, const Point& a, const Point b, const Point c): Figure(parent, a),
                                                                                                    _a(a),
                                                                                                    _b(b),
                                                                                                    _c(c)
{
}

Triangle::~Triangle()
{
}

void Triangle::Draw()
{
	glBegin(GL_POLYGON);
	
	glVertex2d(_a.X, _a.Y);
	glVertex2d(_b.X, _b.Y);
	glVertex2d(_c.X, _c.Y);

	glEnd();
}

Point Triangle::GetA() const
{
	return _a;
}

Point Triangle::GetB() const
{
	return _b;
}

Point Triangle::GetC() const
{
	return _c;
}

void Triangle::SetA(Point value)
{
	_a = value;
}

void Triangle::SetB(Point value)
{

	_b = value;
}

void Triangle::SetC(Point value)
{
	_c = value;
}

void Triangle::Rotate(double angleInDegree, Direction direction)
{
	double t_x, t_y;
	auto rad = angleInDegree * PI / 180;
	if (direction == CounterClockWise) {
		t_x = _a.X;
		t_y = _a.Y;
		_a.X = Position.X + (t_x - Position.X) * cos(rad) - (t_y - Position.Y) * sin(rad);
		_a.Y = Position.Y + (t_y - Position.Y) * cos(rad) + (t_x - Position.X) * sin(rad);
		t_x = _b.X;
		t_y = _b.Y;
		_b.X = Position.X + (t_x - Position.X) * cos(rad) - (t_y - Position.Y) * sin(rad);
		_b.Y = Position.Y + (t_y - Position.Y) * cos(rad) + (t_x - Position.X) * sin(rad);
		t_x = _c.X;
		t_y = _c.Y;
		_c.X = Position.X + (t_x - Position.X) * cos(rad) - (t_y - Position.Y) * sin(rad);
		_c.Y = Position.Y + (t_y - Position.Y) * cos(rad) + (t_x - Position.X) * sin(rad);
	}
	else {
		t_x = _a.X;
		t_y = _a.Y;
		_a.X = Position.X + (t_x - Position.X) * cos(rad) + (t_y - Position.Y) * sin(rad);
		_a.Y = Position.Y + (t_y - Position.Y) * cos(rad) - (t_x - Position.X) * sin(rad);
		t_x = _b.X;
		t_y = _b.Y;
		_b.X = Position.X + (t_x - Position.X) * cos(rad) + (t_y - Position.Y) * sin(rad);
		_b.Y = Position.Y + (t_y - Position.Y) * cos(rad) - (t_x - Position.X) * sin(rad);
		t_x = _c.X;
		t_y = _c.Y;
		_c.X = Position.X + (t_x - Position.X) * cos(rad) + (t_y - Position.Y) * sin(rad);
		_c.Y = Position.Y + (t_y - Position.Y) * cos(rad) - (t_x - Position.X) * sin(rad);
	}
}

std::vector<Point> Triangle::GetVertexes()
{
	auto result = std::vector<Point>();

	return result;
}

double Triangle::GetArea()
{
	return  0;
}

void Triangle::Move(double dx, double dy)
{
	_a.X += dx;
	_b.X += dx;
	_c.X += dx;

	_a.Y += dy;
	_b.Y += dy;
	_c.Y += dy;
}

void Triangle::Hide()
{
		
}

void Triangle::Show()
{
}
