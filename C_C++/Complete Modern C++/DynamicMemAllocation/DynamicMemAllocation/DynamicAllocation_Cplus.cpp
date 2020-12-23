#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

void DynamicAllocation_Cplus()
{
	///Allocation using C++ 
	int *p = new int[5];

	for (size_t i = 0; i < 5; i++)
	{
		p[i] = i;
	}

	for (size_t i = 0; i < 5; i++)
	{
		cout << p[i] << " ";
	}

	delete[] p;
}
