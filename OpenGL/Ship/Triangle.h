#pragma once
#include "Figure.h"

class Triangle : public Figure
{
public:

	Triangle(Figure* const parent, const Point& position, const double a, const double b, const double angle);

	Triangle(Figure* const parent, const double a, const double b, const double angle);

	~Triangle() override;
	void Draw() override;

	double GetA() const;
	double GetB() const;
	double GetAngle() const;

	void   SetA(double value);
	void   SetB(double value);
	void   SetAngleInDegree(double value);
	void Rotate(double angleInDegree) override;
	Point GetCenter() override;
private:
	double _a, _b, _angle;
};