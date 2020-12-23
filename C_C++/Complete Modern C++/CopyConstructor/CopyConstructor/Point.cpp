#include "Point.h"
Point::Point()
{
}

Point::Point(int xp, int yp)
{
	x = xp; 
	y = yp;
}

Point::Point(Point & point)
{
	this->x = point.x; 
	this->y = point.y; 
}

void Point::PrintInfo()
{
	cout << "(x,y): " << x << "-" << y << endl;
}


Point::~Point()
{
}
