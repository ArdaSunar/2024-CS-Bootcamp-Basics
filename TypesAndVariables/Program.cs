// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int veri tipinin alabileceği maksimum değerdir.
int number1 = 2147483647;
Console.WriteLine(number1);
//long veri tipi daha büyük sayılar kapsar ancak bellekte daha fazla yer tutar.
long number2 = 2147483648;
Console.WriteLine(number2);
//short veri tipi -32768 ile 32767 arasındaki sayıları tutar.
short number3 = 32767;
Console.WriteLine(number3);
//byte veri tipi 0 ile 255 arasındaki sayıları tutar
byte number4 = 255;
Console.WriteLine(number4);
//bool true ve false değerlerini tutar
bool condition1 = false;
Console.WriteLine(condition1);
//char karakterleri tutar, int tipine çevrilebilir
char character1 = 'A';
Console.WriteLine(character1);
Console.WriteLine((int)(character1));
//string veri tipi karakterler dizinidir
string text1 = "Merhaba Dünya";
//double ondalıklı sayıları tutar
double number5 = 10.4;
Console.WriteLine(number5);
//decimal virgülden sonra daha fazla sayı tutmak için kullanılır
decimal number6 = 10;
decimal number7 = 10.5M;
Console.WriteLine(number6);
Console.WriteLine(number7);
//enum
enum Days
{
    Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
}

