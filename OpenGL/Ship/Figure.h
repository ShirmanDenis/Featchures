#pragma once
#define PI 3.14159265 
#include <utility>

struct Color
{
	unsigned char R;
	unsigned char G;
	unsigned char B;
	Color() : Color(0,0,0)
	{
	}

	Color (unsigned char r, unsigned char g, unsigned char b): R(r), G(g), B(b)
	{
	}

	static Color Red()
	{
		return Color(255, 0, 0);
	}
	static Color Green()
	{
		return Color(0, 255, 0);
	}
	static Color Blue()
	{
		return  Color(0, 0, 255);
	}
	static Color Yellow()
	{
		return Color(255, 255, 0);
	}
	static Color Turquoise()
	{
		return Color(0, 255, 255);
	}
	static Color Pink()
	{
		return Color(255, 0, 255);
	}
	static Color White()
	{
		return Color(255, 255, 255);
	}
	static Color Black()
	{
		return Color(0, 0, 0);
	}
	static Color Brown()
	{
		return Color(128, 0, 0);
	}
	static Color Orange()
	{
		return Color(255, 128, 0);
	}
	static Color Grey()
	{
		return Color(128, 128, 128);
	}
};

struct Point
{
	double X;
	double Y;
	Point() : X(0), Y(0) {}
	Point(double x, double y)
	{
		X = x;
		Y = y;
	}
};

class Figure{
public:
	Color Color = Color.White();
	Point Position{ 0,0 };
	
	Figure(Figure* parent, const Point& position);

	explicit Figure(Figure* parent = nullptr);
	virtual void Rotate(double angleInDegree) = 0;
	virtual void Draw() = 0;
	virtual Point GetCenter() = 0;

	Figure* GetParent() const;

	virtual ~Figure();
private:
	Figure* _parent;
};