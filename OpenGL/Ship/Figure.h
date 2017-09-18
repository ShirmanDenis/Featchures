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
	Point(double x, double y)
	{
		X = x;
		Y = y;
	}
};

class Figure{
public:
	Figure(Figure* parent, const Point& position);

	Figure(const Figure& other)
		: Color(other.Color),
		  Position(other.Position),
		  _parent(other._parent)
	{
	}

	Figure(Figure&& other) noexcept
		: Color(std::move(other.Color)),
		  Position(std::move(other.Position)),
		  _parent(other._parent)
	{
	}

	Figure& operator=(const Figure& other)
	{
		if (this == &other)
			return *this;
		Color = other.Color;
		Position = other.Position;
		_parent = other._parent;
		return *this;
	}

	Figure& operator=(Figure&& other) noexcept
	{
		if (this == &other)
			return *this;
		Color = std::move(other.Color);
		Position = std::move(other.Position);
		_parent = other._parent;
		return *this;
	}

	explicit Figure(Figure* parent);
protected:
	Color Color = Color.White();
	Point Position{0,0};

	virtual ~Figure();
	virtual void Draw() = 0;

	Figure* GetParent() const;
	
private:
	Figure* _parent;
};
