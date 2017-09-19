#include "Figure.h"

Figure::Figure(Figure * parent, const Point& position) : Figure(parent)
{
	Position.X = position.X;
	Position.Y = position.Y;
}

Figure::Figure(Figure* parent)
{
	_parent = parent;
}

Figure::~Figure()
{

}

double Figure::GetX() const
{
	return Position.X;
}

double Figure::GetY() const
{
	return Position.Y;
}

void Figure::SetX(double value)
{
	Position.X = value;
}

void Figure::SetY(double value)
{
	Position.Y = value;
}

Color Figure::GetColor() const
{
	return Color;
}

void Figure::SetColor(::Color color)
{
	Color.Assign(color);
}

void Figure::Move(double dx, double dy)
{
	Position.X += dx;
	Position.Y += dy;
}

void Figure::Hide()
{
	if (_isVisible)
		_isVisible = false;
}

void Figure::Show()
{
	if (!_isVisible)
		_isVisible = true;
}

bool Figure::IsVisible() const
{
	return _isVisible;
}

Figure * Figure::GetParent() const
{
	return _parent;
}
