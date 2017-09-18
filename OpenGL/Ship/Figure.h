#pragma once
class Color
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
};

//RED(255, 0, 0),
//GREEN(0, 255, 0),
//BLUE(0, 0, 255),
//YELLOW(255, 255, 0),
//TURQUOISE(0, 255, 255),
//PINK(255, 0, 255),
//WHITE(0, 0, 0),
//BLACK(255, 255, 255),
//BROWN(128, 0, 0),
//ORANGE(255, 128, 0),
//GREY(128, 128, 128);
class Figure{
public :
	Color Color;

	Figure(Figure* parent, double x, double y);
	explicit Figure(Figure* parent);
	virtual ~Figure();

	virtual void Draw() = 0;

	Figure* GetParent() const;
	double GetX() const;
	double GetY() const;
	void SetX(double x);
	void SetY(double y);
	
private:
	double _x, _y;
	Figure* _parent;
};
