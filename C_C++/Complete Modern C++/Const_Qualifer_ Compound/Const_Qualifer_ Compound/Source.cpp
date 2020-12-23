#include <iostream>

using namespace std; 



int main()
{
	//Try to modify x1 & x2 and see the compilation output
	int x = 5;
	const int MAX = 12;
	int &ref_x1 = x;
	const int &ref_x2 = x;

	cout << x << " " << MAX << " " << ref_x1 << " " << ref_x2 << endl;
	
	ref_x1 = 1; //then, ref_x1 = x = 1;
	//ref_x2 = 2; //can not modify due to const
	
	cout << x << " " << MAX << " " << ref_x1 << " " << ref_x2 << endl;


	////Try to modify the pointer (e.g. ptr1) and the pointee value (e.g. *ptr1)
	const int *ptr1 = &x;
	int *const ptr2 = &x;
	const int * const ptr3 = &x;

	cout << *ptr1 << " " << *ptr2 << " " << *ptr3 << " " << endl;

	//*ptr1 = 10; //error
	*ptr2 = 12; 
	//*ptr3 = 13; //error

	cout << *ptr1 << " " << *ptr2 << " " << *ptr3 << " " << endl;



	////Find which declarations are valid. If invalid, correct the declaration
	const int *ptr3 = &MAX;
	int *ptr4 = &MAX;

	const int &r1 = ref_x1;
	int &r2 = ref_x2;

	int *&p_ref1 = ptr1;
	const int*&p_ref2 = ptr2;

	system("pause");

}