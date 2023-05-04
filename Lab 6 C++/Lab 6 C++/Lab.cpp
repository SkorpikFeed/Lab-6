#include "Strings.h"
#include <iostream>
using namespace std;
void main()
{
	cout << "Enter a string: ";
	string str;
	cin >> str;
	Numbers num("");
	Symbols symb("");
	Strings string("");
	while (true)
	{
		if (num.IsNumber(str))
		{
			Numbers num(str);
			cout <<"If you want to know the length of the string enter 1, if you want to increase the string enter 2: "<<endl;
			int choice;
			cin >> choice;
			switch (choice)
			{
			case 1:
				cout << "Length of the string is " << num.Length() << endl;
				break;
			case 2:
				num.Increase();
				cout << "The string after increasing is " << num.getNums() << endl;
				break;
			default:
				cout << "Wrong choice" << endl;
				break;
			}
		}
		else if (symb.IsSymbol(str))
		{
			Symbols sym(str);
			cout << "If you want to know the length of the string enter 1, if you want to increase the string enter 2: " << endl;
			int choice;
			cin >> choice;
			switch (choice)
			{
			case 1:
				cout << "Length of the string is " << sym.Length() << endl;
				break;
			case 2:
				sym.Increase();
				cout << "The string after increasing is " << sym.getSyms() << endl;
				break;
			default:
				cout << "Wrong choice" << endl;
				break;
			}
		}
		else
		{
			Strings string(str);
			cout << "If you want to know the length of the string enter 1, if you want to increase the string enter 2: " << endl;
			int choice;
			cin >> choice;
			switch (choice)
			{
				case 1:
					cout << "Length of the string is " << string.Length() << endl;
					break;
				case 2:
					cout << "Enter a string to increase the original string: ";
					cin >> str;
					string.Increase(str);
					cout << "The string after increasing is " << string.getStr() << endl;
					break;
				default:
					cout << "Wrong choice" << endl;
					break;
			}
		}
	}
}