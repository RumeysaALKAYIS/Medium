
using SteakHeapRef;

int number = 2;
double decimalNumber= 2.02;
char a= 'a';
string text = "initial text";
int[] array = {1,2,3};
MyClass myClass = new()
{
    Number = 1,
    Text = "initial value"
};


Methots.Methot( number, decimalNumber, a, text,  array ,myClass);

Console.WriteLine("***********");

Methots.Methot(ref number, ref decimalNumber, ref a,ref text,   ref array, ref myClass);




