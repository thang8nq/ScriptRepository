#include "Header.h"

class Project { };
class Employee {
private:
	std::shared_ptr<Project> m_prj;
public:
	void SetProject(std::shared_ptr<Project> p) {
		m_prj = p;
	}
};

class Printer {
	std::shared_ptr<int> m_pValue;
public:
	void Setvalue(std::shared_ptr<int> p) {
		m_pValue = p;
	}
	void Print() {
		std::cout << *m_pValue;
	}
};
class Number {
	int m_Num{};
public:
	Number(int num) {
		m_Num = num;
	}
	int GetNumber() {
		return m_Num;
	}
	//Constructors and other members
};

void Print(Number & num) {
	cout << num.GetNumber();
}



class Base {
public:
	Base() {};
	void Foo() {
		std::cout << "Base::Foo";
	}
};
class Derived : public Base {
public:
	Base::Base;
};

template<typename T>
T Add(T x, T y) { return x + y; }

template int Add(int, int);



int main()
{
	Derived d{};
	Base *b = &d;


	/*Number n{ 5 };
	Print(n);*/
	//Other code

	/*Printer prn;
	int num{ 69 };
	std::shared_ptr<int> p{ new int{num} };
	prn.Setvalue(p);
	p = nullptr;
	prn.Print();*/

	//std::shared_ptr<Project> p{ new Project() };
	//auto e = new Employee();
	//e->SetProject(p);

	//delete e;

	//return 0;
	//cout << "Print 10 first Finbonacci number" << endl;
	//for (int i = 1; i <= 10; i++)
	//{
	//	cout << Find_Num_In_Fibonacci_Seq(i) << " ";
	//}
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///
	
	//cout << "Print factorial of 10 first Integer number" << endl;
	//for (int i = 0; i < 10; i++)
	//{
	//	cout << i << "! = " << Factorial_Of(i) << endl;
	//}
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///

	//cout << "Find Prime number in 10 first Integer number" << endl;
	//for (int i = 0; i < 10; i++)
	//{
	//	if (isPrimeNum(i))
	//		cout << i << " ";
	//}
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///

	//cout << "Get list Prime number in range from 100 to 200" << endl;
	//Get_List_Prime_In_Range(100, 200);
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///

	//cout << "Find Armstrong number in range from 0 to 1000" << endl;
	//for (int i = 0; i < 1000; i++)
	//{
	//	if (isArmstrongNumber(i))
	//		cout << i << endl;
	//}
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///

	//cout << "Find BCPALINnumber in range from 0 to 1000" << endl;
	//for (int i = 0; i < 1000; i++)
	//{
	//	if (isBCPALINnumber(i))
	//		cout << i << endl;
	//}
	//cout << endl << "--------------------------------------" << endl << endl;
	/////------------------------///

/*
		IntPtrType ptr_a, ptr_b, *ptr_c;
		ptr_a = new int;
		*ptr_a = 3;
		ptr_b = ptr_a;
		cout << *ptr_a << " " << *ptr_b << "\n";

		ptr_b = new int;
		*ptr_b = 9;
		cout << *ptr_a << " " << *ptr_b << "\n";

		*ptr_b = *ptr_a;
		cout << *ptr_a << " " << *ptr_b << "\n";

		delete ptr_a;
		ptr_a = ptr_b;
		cout << *ptr_a << " " << *&*&*&*&*ptr_b << "\n";

		ptr_c = &ptr_a;
		cout << *ptr_c << " " << **ptr_c << "\n";

		delete ptr_a;
		ptr_a = NULL;
	*/

	//auto i = 10; 
	//auto sum = i + 4.3f;


	//const int x = 10; 
	//auto var = x; 
	//auto &ref = x; 
	//auto ptr = &x;
	//cout << ptr << endl;
	//cout << ref << endl;

	//float f = 1.2f; 
	//double d = 3.4; 
	//double d2 = 3.56;
	//double long d3 = 53.43; 

	//cout << sizeof(f) << " " << sizeof(d) << " " << sizeof(d2) << " " << sizeof(d3) << endl;

	//float _f = 5.0f; int a = _f;
	////auto list { 1,2,3,4 };
	//char _str[256]{};

	//char* str = new char[12]{ "Hello world" };
	//char c{ '\0' };
	////char* str = {"dafsdf"};

	system("pause");


}