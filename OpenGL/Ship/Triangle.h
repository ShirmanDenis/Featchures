#pragma once
#include "Figure.h"

class Triangle : Figure
{
public:

	Triangle(Figure* const parent, const Point& position, const double a, const double b, const double angle);

	Triangle(Figure* const parent, const double a, const double b, const double angle);

	~Triangle() override;
	void Draw() override;

	double GetA() const;

	Triangle(const Triangle& other);

	Triangle(Triangle&& other) noexcept;

	Triangle& operator=(const Triangle& other);

	Triangle& operator=(Triangle&& other) noexcept;

	double GetB() const;
	double GetAngle() const;
	void   SetA(double value);
	void   SetB(double value);
	void   SetAngleInDegree(double value);
private:
	double _a, _b, _angle;
};