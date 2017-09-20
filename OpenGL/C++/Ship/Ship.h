#pragma once
#include "Figure.h"
#include "IsoscelesTrapeze.h"
#include "Rectangle.h"
#include "Triangle.h"

namespace GLDrawing {
 class Ship : Figure
 {
 public:
	 void Rotate(double angleInDegree, const Point* around, Direction direction) override;
	 std::vector<Point> GetVertexes() override;
	 double GetArea() override;

 protected:
	 void Draw() override;
 private:
	 IsoscelesTrapeze _deck;
	 Rectangle _mest;
	 Triangle _sail;
 };	
}
