#include "Header.h"

bool isPrimeNum(int number)
{
	if (number < 1)
		return false;

	bool isPrimeNum = true;

	for (int i = 2; i < number; i++)
	{
		if (number % i == 0)
		{
			isPrimeNum = false;
			break;
		}
	}

	return isPrimeNum;
}

int Find_Num_In_Prime_Seq(int index)
{
	/// save list prime number into an array, then get it...

	/// invalid number
	if (index < 1)
		return NULL;

}

vector<int> Get_List_Prime_In_Range(int beg, int end)
{
	vector<int> result; 

	for (int i = beg; i <= end; i++)
	{
		if (isPrimeNum(i))
			result.push_back(i);
	}

	return result;
}


