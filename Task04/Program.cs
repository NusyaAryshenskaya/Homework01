using static System.Console;

WriteLine("Какое из чисел самое большое? ");
Write("Введите  число a: ");
int a = int.Parse(ReadLine());
Write("Введите  число b: ");
int b = int.Parse(ReadLine());
Write("Введите  число c: ");
int c = int.Parse(ReadLine());

if (a > b && a > c)
{
    WriteLine(a);
}
else if (c > a && c > b)
{
    WriteLine(c);
}
else if (b > a && b > c)
{
    WriteLine(b);
}