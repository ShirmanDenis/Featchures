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

	if (IsVisible())
		glColor3ub(Color.R, Color.G, Color.B);
	else
		glColor4f(1, 0, 0, 0); 

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

void Triangle::Rotate(double angleInDegree, const Point* around, Direction direction)
{
	double t_x, t_y;
	auto arroundPoint = (around != nullptr) ? around : &Position;
	auto rad = angleInDegree * PI / 180;
	if (direction == CounterClockWise) {
		t_x = _a.X;
		t_y = _a.Y;
		_a.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) - (t_y - arroundPoint->Y) * sin(rad);
		_a.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) + (t_x - arroundPoint->X) * sin(rad);
		t_x = _b.X;
		t_y = _b.Y;
		_b.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) - (t_y - arroundPoint->Y) * sin(rad);
		_b.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) + (t_x - arroundPoint->X) * sin(rad);
		t_x = _c.X;
		t_y = _c.Y;
		_c.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) - (t_y - arroundPoint->Y) * sin(rad);
		_c.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) + (t_x - arroundPoint->X) * sin(rad);
	}
	else {
		t_x = _a.X;
		t_y = _a.Y;
		_a.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) + (t_y - arroundPoint->Y) * sin(rad);
		_a.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) - (t_x - arroundPoint->X) * sin(rad);
		t_x = _b.X;
		t_y = _b.Y;
		_b.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) + (t_y - arroundPoint->Y) * sin(rad);
		_b.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) - (t_x - arroundPoint->X) * sin(rad);
		t_x = _c.X;
		t_y = _c.Y;
		_c.X = arroundPoint->X + (t_x - arroundPoint->X) * cos(rad) + (t_y - arroundPoint->Y) * sin(rad);
		_c.Y = arroundPoint->Y + (t_y - arroundPoint->Y) * cos(rad) - (t_x - arroundPoint->X) * sin(rad);
	}
}

std::vector<Point> Triangle::GetVertexes()
{
	auto result = std::vector<Point>();

	result.push_back(_a);
	result.push_back(_b);
	result.push_back(_c);

	return result;
}

double Triangle::GetArea()
{
	auto ab = _a.DistanceTo(_b);
	auto bc = _b.DistanceTo(_c);
	auto ac = _a.DistanceTo(_c);

	auto semiperimeter = (ab + bc + ac) / 2.0;
	return sqrt(semiperimeter * (semiperimeter - ab) * (semiperimeter - ac) * (semiperimeter - bc));
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
