#include <iostream>

using namespace std;

int main()
{
    setlocale(0, "");
    int x, i, sum, cost;
    sum = 0;
    cout << "Введите кол. товаров: ";
    cin >> x;
    for (int i = 0; i < x; i++) {
        cout << "Стоимость товара: ";
        cin >> cost;
        sum += cost;
    }
    cout << sum;
    return 0;
}
