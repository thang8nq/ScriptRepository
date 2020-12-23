#include "Header.h"

int Factorial_Of(int number)
{
	/// invalid number
	if (number < 0)
		return NULL;
	
	/// 0! = 1 
	if (number == 0)
		return 1; 

	return number * Factorial_Of(number - 1);
}

