#include "Data.h"



int main() {
	int d, m, a;
	cout << "\nDia: ";
	cin >> d;
	cout << "Mes: ";
	cin >> m;
	cout << "Ano: ";
	cin >> a;
	Data D(d, m, a);
	cout << D.toString();
	system("pause");
	return 0;
}