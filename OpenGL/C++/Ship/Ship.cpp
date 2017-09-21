#include "Ship.h"
using namespace GLDrawing;
bool isTurned = false;
Ship::Ship(Figure* const parent, const Point& position): Figure(parent, position)
{
	_deck = new IsoscelesTrapeze(this, position, 70, 150,250);
	auto a = Point(position.X + _deck->GetBotBase() / 2.0, position.Y + _deck->GetHeight());
	auto b = Point(a.X, a.Y + 200);
	auto c = Point(position.X + _deck->GetBotBase() - (_deck->GetBotBase() - _deck->GetTopBase()), a.Y + a.DistanceTo(b) / 2.0);
	_sail = new Triangle(this, a, b, c);
	_deck->SetColor(Color::Grey());
}

Ship::~Ship()
{
	if (_deck != nullptr)
	{
		delete _deck;
		_deck = nullptr;
	}
	if (_sail != nullptr)
	{
		delete _sail;
		_sail = nullptr;
	}
}

void Ship::Rotate(double angleInDegree, const Point * around, Direction direction)
{
}

std::vector<Point> Ship::GetVertexes()
{
	return std::vector<Point>();
}

double Ship::GetArea()
{
	return 0;
}

void Ship::Draw()
{
	_deck->Show();
	_sail->Show();
	Position.X = _deck->GetX();
	Position.Y = _deck->GetY();
}

void Ship::Move(double dx, double dy)
{
	_deck->Move(dx, dy);
	if (dx < 0 && !isTurned)
	{
		auto newC = _sail->GetC();
		newC.Rotate(_sail->GetA(), 120);
		_sail->SetC(newC);
		isTurned = true;
	}
	else if(isTurned && dx > 0)
	{
		auto newC = _sail->GetC();
		newC.Rotate(_sail->GetA(), 120, CounterClockWise);
		_sail->SetC(newC);
		isTurned = false;
	}
	_sail->Move(dx, dy);
}
