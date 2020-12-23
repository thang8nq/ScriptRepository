#include <iostream>

using namespace std; 

/*
	1. Why using `return a+b` wrong?
*/
//Add two numbers and return the sum
int Add(int *a, int *b)  
{
	return *a + *b; 
}

//Add two numbers and return the sum through the third pointer argument
void AddVal(int *a, int *b, int *result) 
{
	*result = *a + *b; 
}

/*
	
*/
void Swap(int *a, int *b)  //Swap the value of two integers
{
	int *temp = new int(0); //khi cap phat nen gan gia tri mac dinh cho bien, tuy IDE se co gia tri mac dinh neu no k dc gan truoc gia tri
	*temp = *a;
	*a = *b; 
	*b = *temp;
}

/*
	- In ra giai thua cua so tu nhien a su dung de quy
	- CT chung: n! = 1 (neu n = 0); n! = (n - 1)! x n; (neu n > 0) 
*/
int Fact(int a)
{
	if (a < 0) return NULL; 

	int result = 0; 
	
	if (a == 0)
		return 1; 

	result = Fact(a - 1) * a; 
	
	return result;
}

/*
	- In ra giai thua khong su dung de quy
*/
void Factorial(int *a, int *result)       //Generate the factorial of a number (giai thua) and return that through the second pointer argument
{
	*result = 1; 
	for (int i = 1; i <= *a; i++)
	{
		*result *= i;
	}
}

/*
	- In ra day Finbonacci, den so thu n 
	- CT chung: 
		+ La day vo han bat dau bang 2 phan tu 0 va 1 hoac 1 va 1 (trong code thay dung 1 va 1)
		+ So sau bang tong 2 so truoc 
		+ Day Finbonacci: 1 1 2 3 5 8 13 21 ... 
		=> f(n) la so thu n trong day Fibonacci, mac dinh f(1) = 1; f(2) = 1; 
		+ voi n > 2: f(n) = f(n-1) + f(n-2)
*/
int GetNumberFinbonacci(int n)
{
	if (n < 1) return NULL; 

	if (n == 1 || n == 2) return 1; 

	return GetNumberFinbonacci(n - 1) + GetNumberFinbonacci(n - 2);
 }




int main()
{
	int *a = new int(3); 
	int *b = new int(4); 

	int *re; 
	cout << *re << endl;

	int *result = new int();

	cout << *result << endl;

	
	cout << Add(a, b) << endl;
	AddVal(a, b, result);

	cout << *result << endl;

	//Swap(a, b);
	
	cout << *a << " " << *b << endl;

	Factorial(a, result);
	cout << "a: " << *a << " Fac: " << *result << endl;

	for (int i = 0; i < 10; i++)
	{
		//cout << "Fact: " << i << ": " << Fact(i) << endl;
		cout << "GetNumFibonacci: " << i << ": " << GetNumberFinbonacci(i) << endl;
	}
	
	int x = 10; 
	int *ptr = &x;

	system ("pause");
}