#include <stdio.h>
#include <stdlib.h>
#include <iostream>
using namespace std;

void DynamicAllocation_C() 
{
	///Create an array using malloc, calloc, free, realloc 
	//Allocate 
	int num_of_element = 10;
	int *arr1 = (int*)malloc(num_of_element * sizeof(int));
	int *arr2 = (int*)calloc(num_of_element, sizeof(int));

	//Check if allocation successful
	if (arr1 == NULL) exit(0);
	if (arr2 == NULL) exit(0);

	//Assign array 
	for (size_t i = 0; i < num_of_element; i++)
	{
		arr1[i] = i + 1;
		arr2[i] = i + 2;
	}

	//realloc to expand size, also need check null if realloc successfull or not
	arr1 = (int*)realloc(arr1, 2 * num_of_element);

	//Free
	free(arr1);
	free(arr2);
	/// ------------------------------ end C ------------------------------ ///
}
	