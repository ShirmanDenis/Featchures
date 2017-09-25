#pragma once
#include "Figure.h"
#include "IsoscelesTrapeze.h"
#include "Rectangle.h"
#include "Triangle.h"

namespace GLDrawing {
 class Ship : public Figure
 {
 public:

	 Ship(Figure* const parent, const Point& position);

	 void Rotate(double angleInDegree, const Point* around, Direction direction) override;
	 std::vector<Point> GetVertexes() override;
	 double GetArea() override;
	 ~Ship() override;

 protected:
	 void Draw() override;

 public:
	 Point Position;
	 void Move(double dx, double dy) override;
 private:
	 IsoscelesTrapeze* _deck;
	 Triangle* _sail;
 };	
}
