#include <stdio.h>
#include <stdlib.h>
#include <iostream>

using namespace std; 

int main()
{
	int num_col = 3;
	int num_row = 2;

	///2D Array
	//  col1 col2 col3
	// [ 1    2    3 ] -> row1
	// [ 4    5    6 ] -> row2
	
	int *row1 = new int[num_col];
	int *row2 = new int[num_col];

	int **array2D = new int *[2];
	array2D[0] = row1; 
	array2D[1] = row2; 

	for (size_t i = 0; i < num_col; i++)
	{
		for (size_t j = 0; j < num_row; j++)
		{
			array2D[j][i] = (i + j) * 2;
		}
	}

	//print info
	for (size_t i = 0; i < num_row; i++)
	{
		for (size_t j = 0; j < num_col; j++)
		{
			cout << array2D[i][j] << " ";
		}
		cout << endl;
	}

	//release mem
	delete[] row1;
	delete[] row2;

	delete[] array2D;
	getchar();
}