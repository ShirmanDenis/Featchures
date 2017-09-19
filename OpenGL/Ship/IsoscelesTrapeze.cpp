#include "Figure.h"
#include <GL/glew.h>
#include <algorithm>
#include "IsoscelesTrapeze.h"

IsoscelesTrapeze::IsoscelesTrapeze(Figure* parent, Point position, double height, double bot_base, double top_base): Figure(parent, position),
                                                                                                                         _height(height),
                                                                                                                         _botBase(bot_base),
                                                                                                                         _topBase(top_base)
{
}

void IsoscelesTrapeze::Draw()
{
	auto delta = abs(_botBase - _topBase) / 2;
	auto currentX = Position.X;
	auto currentY = Position.Y;

	glBegin(GL_POLYGON);
	glColor3ub(Color.R, Color.G, Color.B);

	glVertex2d(currentX, currentY);

	glVertex2d(currentX -= delta, currentY += _height);
	glVertex2d(currentX += std::max(_botBase, _topBase), currentY);
	glVertex2d(currentX -= delta, currentY -= _height);

	glVertex2d(Position.X, Position.Y);
	glEnd();
}

double IsoscelesTrapeze::GetHeight() const
{
	return _height;
}

double IsoscelesTrapeze::GetTopBase() const
{
	return _topBase;
}

double IsoscelesTrapeze::GetBotBase() const
{
	return _botBase;
}

void IsoscelesTrapeze::SetHeight(double height)
{
	if (height < 0)
		throw std::exception("Value can't be less then zero");
	_height = height;
}

void IsoscelesTrapeze::SetTopBase(double topBase)
{
	if (topBase < 0)
		throw std::exception("Value can't be less then zero");
	_topBase = topBase;
}

void IsoscelesTrapeze::SetBotBase(double botBase)
{
	if (botBase < 0)
		throw std::exception("Value can't be less then zero");
	_botBase = botBase;
}

IsoscelesTrapeze::~IsoscelesTrapeze()
{
}

void IsoscelesTrapeze::Rotate(double angleInDegree, const Point* around, Direction direction)
{

}

std::vector<Point> IsoscelesTrapeze::GetVertexes()
{
	return std::vector<Point>();
}

double IsoscelesTrapeze::GetArea()
{
	return  0;
}
