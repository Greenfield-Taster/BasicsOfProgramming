#include <iostream>

using namespace std;

main()
{
    setlocale(0, "");
    const int number = 6;
    int a[number], i, min, max, dob;
    for (i = 0; i <= (number - 1); i++)
    {
        cout << "Введите " << (i + 1) << " элемент масиву: ";
        cin >> a[i];
    }
    cout << "a[] = { " << a[0];
    for (i = 1; i <= (number - 1); i++)
    {
        cout << " , " << a[i];
    }
    cout << " }" << endl;
    max = a[0];
    min = a[0];
    for (i = 1; i <= (number - 1); i++)
    {
        if (max < a[i])
            max = a[i];
        if (min > a[i])
            min = a[i];
    }
    dob = 1;
    dob = min * max;
    cout << "Добуток минимального и максимального элементов массива равен - " << dob;
}