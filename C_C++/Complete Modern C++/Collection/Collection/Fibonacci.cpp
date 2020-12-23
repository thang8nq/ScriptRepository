#include "Header.h"

//Get Fibonacci at "index" position in the sequence 
int Find_Num_In_Fibonacci_Seq(int index)
{
	/// invalid index
	if (index < 1) 
		return NULL; 

	/// This for seq start with (1 1): 1 1 2 3 5 ....
	if (index == 1 || index == 2)
		return 1;
	return Find_Num_In_Fibonacci_Seq(index - 1) + Find_Num_In_Fibonacci_Seq(index - 2);

	/// This for seq start with (0 1): 0 1 2 3 5 ....
	//if (index == 1)
	//	return 0; 
	//if (index == 2)
	//	return 1;
	//return Find_Num_In_Fibonacci_Seq(index - 1) + Find_Num_In_Fibonacci_Seq(index - 2);
}