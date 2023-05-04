#include "Strings.h"
double Strings::Length()
{
	return str.length();
}
void Strings::Increase(string s)
{
	str += s;
}
Strings::Strings(string string)
{
	str = string;
}
Strings::Strings()
{
	str = "";
}
Numbers::Numbers(string s)
{
	if(IsNumber(s))
		nums = s;
	else
		nums = "0";
}
bool Numbers::IsNumber(string num)
{
	for (int i = 0; i < num.length(); i++)
	{
		if (num[i] < '0' || num[i] > '9')
			return false;
	}
	return true;
}
double Numbers::Length()
{
	return nums.length();
}
void Numbers::Increase()
{
	string temp = "";
	for (int i = 0; i < nums.length(); i++)
	{
		temp += nums[i];
		temp += nums[i];
	}
	nums = temp;
}
Symbols::Symbols(string s)
{
	if (IsSymbol(s))
		syms = s;
	else
		syms = "";
}
bool Symbols::IsSymbol(string sym)
{
	for (int i = 0; i < sym.length(); i++)
	{
		if (sym[i] >= '0' && sym[i] <= '9')
			return false;
	}
	return true;
}
double Symbols::Length()
{
	return syms.length();
}
void Symbols::Increase()
{
	string temp = "";
	for (int i = 0; i < syms.length(); i++)
	{
		if (syms[i] == 'k')
		{
			temp += syms[i];
			temp += syms[i];
		}
		else temp += syms[i];
	}
	syms = temp;
}
