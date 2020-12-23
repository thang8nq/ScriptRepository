#include "Header.h"

bool isArmstrongNumber(int number)
{
	int num = 0;
	int sum = 0;
	int originNum = number;

	if (number >= 0)
	{
		stack <int> st;

		//or can use NumberIntoArray();

		do
		{
			num = number % 10;
			st.push(num);
			number /= 10;
		} while (number >= 1);


		while (!st.empty())
		{
			int num = st.top();
			sum += pow(num, 3);
			st.pop();
		}

		if (sum == originNum)
		{
			return true;
		}
	}
	return false;
}

