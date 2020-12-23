#include <iostream>
using namespace std; 

#define Square(x) x*x

int main()
{
	int val = 5;
	int result = Square(val + 1);
	cout << result << endl;

	system("pause");
}