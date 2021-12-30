#include <iostream>
#include <math.h>

using namespace std;

int A_task2()
{
    setlocale(0, "");
    int* array;
    unsigned int number;
    cout << "Введите размерность массива: ";
    cin >> number;
    array = new int[number];
    int vvod, i;
    cout << "Введите элемент массива с клавиатуры(0), случайными числами(1): \n";
    cin >> vvod;
    if (vvod == 0)
        for (i = 0; i < number; i++)
        {
            cout << "Введите " << (i + 1) << " элемента массива: ";
            cin >> array[i];
        }
    else
        for (i = 0; i < number; i++)
            array[i] = -10 + rand() % 21;

    int max, min, dob;
    cout << "a[] = { " << array[0];

    for (i = 1; i <= (number - 1); i++)
    {
        cout << " , " << array[i];
    }
    cout << " }" << endl;
    max = array[0];
    min = array[0];


    for (i = 1; i <= (number - 1); i++)
    { 
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    dob = 1;
    dob = min * max;
    cout << "Добуток минимального и максимального элементов массива равен = " << dob<< endl ;
    
    cout << "Размер массива: " << (sizeof(int) * number)<< " byte "<< endl;

    delete[]array;
    return 0;
}