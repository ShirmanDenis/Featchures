#include "Ship.h"

void GLDrawing::Ship::Rotate(double angleInDegree, const Point * around, Direction direction)
{
}

std::vector<GLDrawing::Point> GLDrawing::Ship::GetVertexes()
{
}

double GLDrawing::Ship::GetArea()
{
}

void GLDrawing::Ship::Draw()
{
	_deck.Draw();
	_mest.Draw();
	_sail.Draw();
}
