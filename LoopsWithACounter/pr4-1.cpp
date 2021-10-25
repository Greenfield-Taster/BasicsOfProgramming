#include <iostream>
#include<math.h>

using namespace std;

int main()
{
	setlocale(0, "");
	float w, n;
	//int m;
	cout << "¬ведите n\n";
	cin >> n;
	w = 1;
	int m = 1;
	do {
		w *= sqrt(4 * m - 2);
		m++;
	} while (m <= n);
	cout << "w= " << w - sqrt(n) << endl;
	system("pause");
	return 0;
}