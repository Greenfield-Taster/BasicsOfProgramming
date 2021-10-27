#include <iostream>
#include "pr4-2.h"

using namespace std;

void Pr2Method()
{
    setlocale(0, "");
    int b, i;
    cout << "¬ведите b: \n";
    cin >> b;
    for (i = 35; i > b; i--)
        cout << i << "@";
}