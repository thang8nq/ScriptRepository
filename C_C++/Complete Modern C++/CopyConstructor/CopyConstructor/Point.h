#pragma once
#include<iostream>
using namespace std;

class Point
{
private: 
	int x, y; 

public:
	Point();
	Point(int x, int y);
	Point(Point &point); //CopyConstructor
	void PrintInfo();
	~Point();
};

