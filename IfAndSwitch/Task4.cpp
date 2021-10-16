#include <iostream>
#include "Task4.h"

using namespace std;

void Task4Method()
{
	setlocale(0, "");
	while (true)
	{
		int a;
		cout << "a=";
		cin >> a;
		switch (a)
		{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12: cout << "31\n";
			break;
		case 4:
		case 6:
		case 9:
		case 11: cout << "30\n";
			break;
		case 2: cout << "28; 29 в высокосном\n";
			break;
		default:
			cout << "Такого месяца нет\n";
			break;
		}
	}
}