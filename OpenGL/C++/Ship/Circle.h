#pragma once
#include "Figure.h"
namespace GLDrawing
{
	class Circle : public Figure
	{
	public:
		Circle(Figure* parent, const Point& position, double radius) : Figure(parent, position)
		{
			Radius = radius;
		}
		double Radius;

		void Rotate(double angleInDegree, const Point* around, Direction direction) override;
		std::vector<Point> GetVertexes() override;
		double GetArea() override;
	protected:
		void Draw() override;
	private:
		int _num = 10000;
	};
}
