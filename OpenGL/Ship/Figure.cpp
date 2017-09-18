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

Figure * Figure::GetParent() const
{
	return _parent;
}
