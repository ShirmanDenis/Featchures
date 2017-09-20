#include "Figure.h"
#include <GL/glew.h>
using namespace GLDrawing;
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

	glEnable(GL_ALPHA_TEST);
	glEnable(GL_BLEND);
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);

	Draw();

	glDisable(GL_BLEND);
	glDisable(GL_ALPHA_TEST);
}

void Figure::Show()
{
	if (!_isVisible)
		_isVisible = true;

	Draw();
}

bool GLDrawing::Figure::IsVisible() const
{
	return _isVisible;
}

Figure * Figure::GetParent() const
{
	return _parent;
}
