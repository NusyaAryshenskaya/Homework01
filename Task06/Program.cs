using static System.Console;

WriteLine("Является данное число Четным? ");
Write("Введите  число a: ");
int a = int.Parse(ReadLine());

 if (a%2==0)
 {
    WriteLine ("Да");
 }
 else
 {
    WriteLine ("Нет");
 }