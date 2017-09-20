#pragma once
#include "Figure.h"
namespace GLDrawing {
	class Rectangle : public Figure
	{
	public:
		Rectangle(Figure* const parent, const Point bottom_left, const Point top_right)
			: Figure(parent, bottom_left),
			_bottomLeft(bottom_left),
			_topRight(top_right)
		{
		}

		void SetBottomLeft(Point a);
		void SetTopRight(Point b);

		Point GetBottomLeft() const;
		Point GetTopRight() const;

		void Rotate(double angleInDegree, const Point* around = nullptr, Direction direction = ClockWise) override;
		void Draw() override;
		std::vector<Point> GetVertexes() override;
		double GetArea() override;
		~Rectangle() override {};
	private:
		Point _bottomLeft, _topRight;
	};
}