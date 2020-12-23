#pragma once
#include <iostream>
#include <vector>
#include <stack>

using namespace std;

int Find_Num_In_Fibonacci_Seq(int index);

int Factorial_Of(int number);

/*
- So nguyen to: 
	+ la so tu nhien > 1
	+ chi chia het cho 1 & chinh no
*/
bool isPrimeNum(int number);
int Find_Num_In_Prime_Seq(int index);
vector<int> Get_List_Prime_In_Range(int beg, int end);

/*
- So Armstrong: 
	+ la so co gia tri bang tong lap phuong cua các chu so trong so do 
	+ ex: 0, 1, 153, 370, 371, 407,...
		>> 0^3 = 0
		>> 1^3 = 1
		>> 1^3 + 5^3 + 3^3 = 153 
		>> 3^3 + 7^3 + 0^3 = 370
		>> 3^3 + 7^3 + 1^3 = 371
		>> 4^3 = 0^3 + 7^3 = 407 
*/
bool isArmstrongNumber(int number);


/*
- BCPALIN: So doi xung 
	+ la so nguyen, neu doc tu trai qua phai hay tu phai qua trai deu thu duoc mot so giong nhau
	+ noi cach khac, sau khi dao nguoc so, van thu dc so ban dau
	+ ex: 2, 1221, 12321, ...
*/
bool isBCPALINnumber(int number);

//convert string to number
//convert number to string
//array to string 
//convert number to array/vector
vector<int> NumberIntoArray(int number);
