#pragma once
#include "Figure.h"

class Square : public Figure
{
public:
	Square(Figure* const parent, const Point& position, const double a, const double b)
		: Figure(parent, position),
		  _a(a),
		  _b(b)
	{
	}

	Square(Figure* const parent, const double a, const double b)
		: Figure(parent),
		  _a(a),
		  _b(b)
	{
	}

	void SetA(double a);
	void SetB(double b);

	double GetA() const;
	double GetB() const;

	void Rotate(double angleInDegree) override;
	void Draw() override;
	Point GetCenter() override;
private:
	double _a, _b;
};
