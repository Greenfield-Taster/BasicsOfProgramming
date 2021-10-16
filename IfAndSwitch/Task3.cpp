#include <iostream>
#include "Task3.h"

using namespace std;

void Task3Method()
{
	while (true)
	{
		setlocale(0, "");
		int x, y, z;

		cout << "Введите оценку по математике :";
		cin >> x;
		if (x <= 5 || x >= 0)
			cout << "Оценка по математике: " << x << endl;
		else
			cout << "нет такой оценки";

		cout << "Введите оценку по физике :";
		cin >> y;
		if (y <= 5 || y >= 0)
			cout << "Оценка по физике: " << y << endl;
		else
			cout << "нет такой оценки";

		cout << "Введите оценку по укр мове :";
		cin >> z;
		if (z <= 5 || z >= 0)
			cout << "Оценка по укр мове: " << z << endl;
		else
			cout << "нет такой оценки";

		if (x <= 2 || y <= 2 || z <= 2)
			cout << "Не поступил\n";
		else if (((x + y + z) / 2) > 3.75)
			cout << "Поступил на бюджет\n";
		else
			cout << "Поступил на контракт\n";
	}
}