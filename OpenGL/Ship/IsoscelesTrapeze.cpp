#include "Figure.h"
#include <GL/glew.h>
#include <cmath>
#include <algorithm>

class IsoscelesTrapeze : Figure
{
public:
	IsoscelesTrapeze(Figure* parent, double x, double y, double height, double bot_base, double top_base)
		: Figure(parent, x, y),
		  _height(height),
		  _botBase(bot_base),
		  _topBase(top_base)
	{
	}

	IsoscelesTrapeze(Figure* parent, double height, double bot_base, double top_base)
		: Figure(parent),
		  _height(height),
		  _botBase(bot_base),
		  _topBase(top_base)
	{
	}

	void Draw() override
	{
		auto delta = abs(_botBase - _topBase) / 2;

		glBegin(GL_POLYGON);
		glColor3b(Color.R, Color.G, Color.B);
		auto currentX = GetX();
		auto currentY = GetY();

		glVertex2d(currentX, currentY);

		glVertex2d(currentX -= delta, currentY += _height);
		glVertex2d(currentX += std::max(_botBase, _topBase), currentY);
		glVertex2d(currentX -= delta, currentY -= _height);

		glVertex2d(GetX(), GetY());
		glEnd();
	};
	double GetHeight() const
	{
		return _height;
	}
	double GetTopBase() const
	{
		return _topBase;
	}
	double GetBotBase() const
	{
		return _botBase;
	}
	void SetHeight(double height)
	{
		_height = height;
	}
	void SetTopBase(double topBase)
	{
		_topBase = topBase;
	}
	void SetBotBase(double botBase)
	{
		_botBase = botBase;
	}

	~IsoscelesTrapeze() override
	{
	}
private:
	double _height, _botBase, _topBase;
	
};
