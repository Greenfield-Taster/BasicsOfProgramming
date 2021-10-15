#include <iostream>
#include "Task1.h"

using namespace std;

void Task1Method()
{
    while (true)
    {

        setlocale(0, "");
        float a;
        cout << "Введите A: ";
        cin >> a;
        if ((a > -6 && a <= 7) || (a >= 10 && a < 30))
            printf("Диапазон - (-6;7] OR [10;30)\nА - входит в диапазон\n", a);
        else
            printf("А - не входит в диапазон\n", a);
    }
}