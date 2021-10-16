#include <iostream>
#include <math.h>
#define PI 3.14
#include "Task2.h"

using namespace std;

void Task2Method()
{
	float x, a = 15;
	cout << "x= ";
	cin >> x;
	x = x * PI / 180;
	a = 15 ? sqrt(a) : 2 * x + cos(x);
	printf("a=%f\n ", a);

	system("pause");
}