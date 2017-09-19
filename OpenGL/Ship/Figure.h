#pragma once
#define PI 3.14159265 
#include <utility>
#include <vector>

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
	void Assign(const Color& color)
	{
		R = color.R;
		G = color.G;
		B = color.B;
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

enum Direction
{
	ClockWise,
	CounterClockWise
};

class Figure{
public:
	Figure(Figure* parent, const Point& position);
	explicit Figure(Figure* parent = nullptr);

	virtual void Rotate(double angleInDegree, Direction direction = ClockWise) = 0;
	virtual void Draw() = 0;
	virtual std::vector<Point> GetVertexes() = 0;
	virtual double GetArea() = 0;

	double GetX() const;
	double GetY() const;
	void SetX(double value);
	void SetY(double value);
	Color GetColor() const;
	void  SetColor(Color color);
	virtual void Move(double dx, double dy);
	virtual void Hide();
	virtual void Show();
	bool IsVisible() const;
	Figure* GetParent() const;

	virtual ~Figure();

protected:
	Color Color = Color.White();
	Point Position{ 0,0 };
private:
	Figure* _parent;
	bool _isVisible = false;
};
