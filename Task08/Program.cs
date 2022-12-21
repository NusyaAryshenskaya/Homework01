using static System.Console;

WriteLine("Все четные числа от 0 до N? ");
Write("Введите  число N: ");
int N = int.Parse(ReadLine());
int a = 0;

while (a <= N);
{
 if (a%2==0) 
 {
 WriteLine($"{a} ");
 a = a++;
}
}