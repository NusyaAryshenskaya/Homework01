using static System.Console;

WriteLine("Какое из чисел больше? ");
Write("Введите  число a: ");
int a = int.Parse(ReadLine());
Write("Введите  число b: ");
int b = int.Parse(ReadLine());

if (a > b)
{
    WriteLine(a);
}
else
{
    WriteLine(b);
}
