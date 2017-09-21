#include "Circle.h"
#include <GL/glew.h>
using namespace GLDrawing;
void Circle::Rotate(double angleInDegree, const Point * around, Direction direction)
{
}

std::vector<Point> Circle::GetVertexes()
{
	return {};
}

double Circle::GetArea()
{
	return 0;
}

void Circle::Draw()
{
	glColor3ub(Color.R, Color.G, Color.B);
	glBegin(GL_POLYGON);

	for (int i = 0; i < _num; i++)
	{
		float angle = 2.0 * 3.1415926 * float(i) / float(_num);

		float dx = Radius * cosf(angle);
		float dy = Radius * sinf(angle);

		glVertex2f(Position.X + dx, Position.Y + dy);
	}

	glEnd();
}
