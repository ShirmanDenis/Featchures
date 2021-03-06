#pragma once
#include "Figure.h"
namespace GLDrawing {
	class IsoscelesTrapeze : public Figure
	{
	public:
		IsoscelesTrapeze(Figure* parent, Point position, double height, double bot_base, double top_base);

		void Draw() override;

		double GetHeight() const;

		double GetTopBase() const;

		double GetBotBase() const;

		void SetHeight(double height);

		void SetTopBase(double topBase);

		void SetBotBase(double botBase);

		~IsoscelesTrapeze() override;
		void Rotate(double angleInDegree, const Point* around = nullptr, Direction direction = ClockWise) override;
		std::vector<Point> GetVertexes() override;
		double GetArea() override;
	private:
		double _height, _botBase, _topBase;
	};
}