#include <iostream>

using namespace std;

int main()
{
	const int number = 3;// обьявляем размерность массива
	int array[number][number] = { {1,2,3} ,{4,5,6} ,{7,8,9} };//обьявляем массив

	for (int i = 0; i < 3; i++)//первый цыкл, условие для размерности рядка, проверяет и выводит
	{
		for (int j = 0; j < 3; j++)//второй цыкл, условие для размерности столбца, проверяет и выводит
		{
			cout << array[i][j] << "\t";//вывод массива
		}

		cout << endl;
	}
	return 0;
}