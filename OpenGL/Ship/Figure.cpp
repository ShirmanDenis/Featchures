#include "Figure.h"

Figure::Figure(Figure * parent, double x, double y) : Figure(parent)
{
	_x = x;
	_y = y;
}

Figure::Figure(Figure* parent)
{
	_parent = parent;
}

Figure::~Figure()
{

}

Figure * Figure::GetParent() const
{
	return _parent;
}

double Figure::GetX() const
{
	return _x;
}

double Figure::GetY() const
{
	return _y;
}

void Figure::SetX(double x)
{
	_x = x;
}

void Figure::SetY(double y)
{
	_y = y;
}
