#include <string>
#include <iostream>
#include <ctime>
#include <string>
using namespace std;
class Data
{
private:
	int dia, mes, ano;
public:
	Data();
	Data(int dia, int mes, int ano);
	Data(const Data &d);
	bool setDia(int dia);
	bool setMes(int mes);
	bool setAno(int ano);
	std::string toString();
};

