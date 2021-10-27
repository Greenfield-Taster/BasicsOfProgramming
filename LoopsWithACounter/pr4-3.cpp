#include <iostream>
#include "pr4-3.h"

using namespace std;

void Pr3Method()
{
    setlocale(0, "");
    int numberOfGoods, sum, cost;

    sum = 0;
    cout << "Введите кол. товаров: ";
    cin >> numberOfGoods;
    
    for (int i = 0; i < numberOfGoods; i++) {
        cout << "Стоимость товара: ";
        cin >> cost;
        sum += cost;
    }
    cout << sum;
}