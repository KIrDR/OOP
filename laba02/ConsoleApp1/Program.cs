using System.Text;

//--------------TYPES-----------------

//1a
Console.WriteLine(" 1a  \n");

bool a0 = true;
Console.WriteLine("bool = " + a0);

byte a1 = 255;
Console.WriteLine("byte = " + a1);

sbyte a2 = 127;
Console.WriteLine("sbyte = " + a2);

char a3 = 'o';
Console.WriteLine("char = " + a3);

decimal a4 = 6.9745533332235565m;
Console.WriteLine("decimal = " + a4);

double a5 = 5.0855676567;
Console.WriteLine("double = " + a5);

float a6 = 3.667f;
Console.WriteLine("float = " + a6);

int a7 = 2147483647;
Console.WriteLine("int = " + a7);

uint a8 = 4294967295;
Console.WriteLine("uint = " + a8);

long a9 = 9223372036854775807;
Console.WriteLine("long = " + a9);

ulong a10 = 18446744073709551615;
Console.WriteLine("ulong = " + a10);

short a11 = 32767;
Console.WriteLine("short = " + a11);

ushort a12 = 65535;
Console.WriteLine("ushort = " + a12 + "\n\n 1b \n\n");


// 1b 

byte b0 = 255;

short b1 = b0; 

int b2 = b1;

long b3 = b2;

float b4 = b3;

Console.WriteLine("byte-->short-->int-->long-->float: " + b4 + "\n");


float b5 = 4.56f;
float b6 = 10.66f;
byte b7 = (byte)(b5 + b6);
sbyte b8 = (sbyte)(b5 + b6);
short b9 = (short)(b5 + b6);
int b10 = (int)(b5 + b6);
long b11 = (long)(b5 + b6);
Console.WriteLine("float-->byte: " + b7);
Console.WriteLine("float-->sbyte: " + b8);
Console.WriteLine("float-->short: " + b9);
Console.WriteLine("float-->int: " + b10);
Console.WriteLine("float-->long: " + b11 + "\n\n");

/* класс Convert способ для преобразования значений.
 * Для этого в нем определены следующие статические методы:
В качестве параметра в эти методы может передаваться значение
различных примитивных типов, необязательно строки
ToBoolean(value)
ToByte(value)
ToChar(value)
ToDateTime(value)
ToDecimal(value)
ToDouble(value)
ToInt16(value)
ToInt32(value)
ToInt64(value)
ToSByte(value)
ToSingle(value)
ToUInt16(value)
ToUInt32(value)
ToUInt64(value) */

int C = Convert.ToInt16("63");

Console.WriteLine(C);


//  1с 
/* Упаковка — это действие по приведению экземпляра типа значения к экземпляру ссылочного типа.
   Ссылочным типом может быть либо класс object, либо интерфейс 

   Распаковка представляет собой обратную операцию,
   предусматривающую приведение объекта обратно к исходному типу значения
 */

int c0 = 9;
object Papa = c0;
float c1 = (int)(Papa);
Console.WriteLine(c1);


float c2 = 5.948548f;
object c3 = c2;
double c4 = (float)c3;
Console.WriteLine(c4);

// 1d
/*Неявно типизированные локальные переменные (ключевое слово var; глава 2) позволяют
 * не указывать тип переменной в операторе объявления,
 * разрешая компилятору выводить его самостоятельно. Это сокращает беспорядок,
 * а также делает возможными анонимные типы (глава 4), которые представляют собой простые классы,
 * создаваемые на лету и обычно применяемые в финальном выводе запросов LINQ.
 * Массивы также могут быть неявно типизированными (см. главу 2).*/

var ii = 2.68;
var jj = 3.84;
var kk = ii + jj;

Console.WriteLine("\n\n" + kk);

// 1e 

int? e0, e1, e2;

e0 = 1; 
e1 = -1;
e2 = null;

string? e3, e4, e5;

e3 = "Bro";
e4 = "u ar the best";
e5 = null;

Console.WriteLine(e0 + "\n" + e1 + "\n" + e2 + "\n" + e3 + "\n" + e4 + "\n" + e5);
// в консоль значение null не выводится как символ. Пусто просто ) 

// 1f 

var f0 = 12.5;
double f1 = 12.2;
if (f1.GetTypeCode() == f0.GetTypeCode())
{
    Console.WriteLine(f0 + "    var присвоилось тип double");
}


// string 
// 2a 

string g0 = "Hello i'm from Belarus";
string g1 = "BCHB";
string g2 = "BCHB";

Console.WriteLine("\n\n g0 = " + g0 + "\n g1 = " + g1 + "\n g2 = " + g2);

if (g0 == g1)
{
    Console.WriteLine("строки g0 and g1 одинаковы");
}
else
{
    Console.WriteLine("строки g0 and g1 отличаются");
}
if (g1 == g2)
{
    Console.WriteLine("строки g1 and g2 одинаковы ");
}
else
{
    Console.WriteLine("строки g1 and g2 отличаются");
}

// 2b

string h0 = "i like icecream with chocolate ";
string h1 = "and big sandwich ";
string h2 = "my best friend is Dimka";

Console.WriteLine($"Сцепление строк: {String.Concat(h0, h1)}");
string h3 = String.Copy(h1); // This API should not be used to create mutable strings. 
                             // Этот API не следует использовать для создания изменяемых строк.
/*Начиная с .NET Core 3,0 этот метод является устаревшим.
 * Однако мы не рекомендуем использовать его в любой реализации .NET.
 * В частности, из-за изменений в развернутых строках в .NET Core 3,0,
 * в некоторых случаях Copy метод не создает новую строку,
 * а просто возвращает ссылку на существующую интернированную строку.*/
Console.WriteLine($"Копирование строки: {h3}");
Console.WriteLine($"Выделение подстроки: {h2.Substring(9)}");

Console.WriteLine($"Разделение строки на слова: "); 
string[] h4 = h2.Split(' ');
foreach (var h5 in h4)
{
    Console.WriteLine($"<{h5}>");
}

Console.WriteLine("\nвставки подстроки в заданную позицию{0}", h2.Insert(7, "-best"));

Console.WriteLine("\nудаление заданной подстроки: {0}", h0.Remove(7,14));

// 2c
string i0 = "";
string i1 = null;
Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(i0)}");
Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(i1)}");
Console.WriteLine($"1 строка=2 строка: {i0 == i1}");
Console.WriteLine($"Сцепление: {String.Concat(i0, i1)}");

// 2d  

StringBuilder j0 = new StringBuilder("bbcd", 5);
j0.Append(new char[] { 'e', 'f', 'g' });
j0.Insert(0, "a");
j0.Remove(2, 1);
Console.WriteLine($"StringBuilder: {j0}");


// Array

int[,] k0 = { { 1, 2,3}, { 4 , 5, 6 }, { 7, 8, 9} };

int rows = k0.GetUpperBound(0) + 1;
int columns = k0.Length / rows;
for (int k1 = 0; k1 < rows; k1++)
{
    for (int k2 = 0; k2 < columns; k2++)
    {
        Console.Write($"{k0[k1, k2]} \t");
    }
    Console.WriteLine();
}

// 3b 

string[] l0 = { " Mum" , " and" , " dad" , " are", " family."};

Console.WriteLine($"Длинна строчного массива : {l0.Length}");

foreach (string l1 in l0)
{
    Console.WriteLine(l1);
}

Console.WriteLine("Введите индекс элемента, который хотите изменить (0-4)");
int l2 = Convert.ToInt32(Console.ReadLine());

string l3 = Console.ReadLine();
l0[l2] = l3;

Console.WriteLine(" ");
foreach (string l1 in l0)
{
    Console.WriteLine(l1);
}

// 3 c 

int[][] m0 = new int[3][];

Console.WriteLine("Сейчас будем заполнять ступенчатый массив:");


int[] m = {0,0,0,0,0,0,0,0,0};
for (int i = 0; i < 9; i++)
{
    m[i] = i;
}

m0[0] = new int[] { m[0], m[1]};
m0[1] = new int[] { m[2], m[3], m[4] };
m0[2] = new int[] { m[5], m[6], m[7], m[8] };
foreach (int[] row in m0)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}

// 3d

var toothArray = new string[3][];

for (var i = 1; i < 4; i++)
{
    toothArray[i - 1] = new string[i];
}

for (var i = 0; i < 3; i++)
{
    for (var j = 0; j < toothArray[i].Length; j++)
    {
        Console.WriteLine("toothArray[{0}][{1}]: ", i, j);
        toothArray[i][j] = Console.ReadLine();
    }
}

Console.WriteLine();
for (var i = 0; i < 3; i++)
{
    for (var j = 0; j < toothArray[i].Length; j++)
    {
        Console.Write("{0} ", toothArray[i][j]);
    }

    Console.WriteLine();
}

// 4 Tuple
var tuple = ( 1, "mum", '3', "dad", (ulong)5 );

Console.WriteLine("Какой элемент корте<жа хотите вывести ?");
int choise = Convert.ToInt32(Console.ReadLine());
switch (choise)
{
    case 1:
        Console.WriteLine(tuple.Item1);
        break;
    case 2:
        Console.WriteLine(tuple.Item2);
        break;
    case 3:
        Console.WriteLine(tuple.Item3);
        break;
    case 4:
        Console.WriteLine(tuple.Item4);
        break;
    case 5:
        Console.WriteLine(tuple.Item5);
        break;
    default:
        Console.WriteLine("Неверный ввод!");
        break;
}

Console.WriteLine("\n Выведем весь кортеж: " +
    "{0} , {1} , {2} , {3} , {4}" ,tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);

int int1;
string string1, string2;
char char1;
ulong ulong1;
(_, string1, _, _, ulong1) = tuple;
(int1 , _, char1, string2, _) = tuple;

var tuple1 = (1, 2, 3, "131", '1');
var tuple2 = (1, 2, 3, "131", '1');

Console.WriteLine(tuple1 == tuple2);



// 5 Локальная функция 

(int, int, int, char) LocalFunction(int[] numbers, string str)
{
    var minNum = int.MaxValue;
    var maxNum = int.MinValue;
    var sumNums = 0;
    foreach (var num in numbers)
    {
        if (num < minNum)
        {
            minNum = num;
        }   

        if (num > maxNum)
        {
            maxNum = num;
        }

        sumNums += num;
    }

    return (maxNum, minNum, sumNums, str[0]);

}
var nums = new[] 
    { 34, 124, 12, 4, 24};
var str = "ohoh";
Console.WriteLine(LocalFunction(nums, str));


// 6 Работа с checked/unchecked:

void LocalFunction1()
{
    unchecked
    {
        var maxValue = int.MaxValue;
        maxValue++;
        Console.WriteLine(maxValue);
    }
}

void LocalFunction2()
{
    checked
    {
        var maxValue = int.MaxValue;
        maxValue++;
        Console.WriteLine(maxValue);
    }

}

LocalFunction1();
LocalFunction2();


Console.WriteLine("Hello, World!");