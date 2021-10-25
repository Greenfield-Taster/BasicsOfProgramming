#include <iostream>

using namespace std;

int main()
{
    setlocale(0, "");
    int b, i;
    cout << "Введите b: \n";
    cin >> b;
    for (i = 35; i > b; i--) 
        cout << i << "@";
    return 0;
}
