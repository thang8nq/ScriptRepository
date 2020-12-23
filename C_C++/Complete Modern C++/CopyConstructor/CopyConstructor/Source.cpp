#include <iostream>
#include "CopyConstructor.h"
#include "Point.h"
using namespace std; 

int main()
{

	Point p1(1, 2);
	Point p2 = p1; //Shallow copy, point same address 
	p1.PrintInfo();
	p2.PrintInfo();

	p1; //lost data from p2

	Point p3(3, 4);

	system("pause");
}