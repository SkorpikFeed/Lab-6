#pragma once
#include <string>
using namespace std;
class Strings
{
protected:
	string str;
public :
	string getStr() { return str; }
	Strings(string string);
	Strings();
	virtual double Length();
	virtual void Increase(string s);
};
class Numbers : Strings
{
private: 
	string nums;
public:
	string getNums() { return nums; }
	Numbers(string s);
	bool IsNumber(string num);
	virtual double Length();
	virtual void Increase();
};
class Symbols : Strings
{
private:
	string syms;
public:
	string getSyms() { return syms; }
	Symbols(string s);
	bool IsSymbol(string sym);
	virtual double Length();
	virtual void Increase();
};
