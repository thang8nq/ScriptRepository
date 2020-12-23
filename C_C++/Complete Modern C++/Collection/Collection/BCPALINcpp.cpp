#include "Header.h"

vector<int> NumberIntoArray(int number)
{
	vector<int> result;

	do
	{
		result.push_back(number % 10);
		number /= 10;
	} while (number >= 1);

	return result;
}

bool isBCPALINnumber(int number)
{
	if (number < 0) return false;

	vector<int> vec = NumberIntoArray(number);
	int size = vec.size();
	int i = 0; 
	while (i < size/2 && vec.at(i) == vec.at(size - i - 1))
	{
		i++;
	}

	if (i == size / 2) return true;

	return false;
}