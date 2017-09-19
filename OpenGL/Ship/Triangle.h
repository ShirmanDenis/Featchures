#pragma once
#include "Figure.h"

class Triangle : public Figure
{
public:

	Triangle(Figure* const parent, const Point& a, const Point b, const Point c);

	~Triangle() override;
	Point GetA() const;
	Point GetB() const;
	Point GetC() const;
	void   SetA(Point value);
	void   SetB(Point value);
	void   SetC(Point value);
	void Rotate(double angleInDegree, Direction direction = ClockWise) override;
	std::vector<Point> GetVertexes() override;
	double GetArea() override;
	void Move(double dx, double dy) override;
	void Hide() override;
	void Show() override;
protected:
	void Draw() override;
private:
	Point _a, _b, _c;
};