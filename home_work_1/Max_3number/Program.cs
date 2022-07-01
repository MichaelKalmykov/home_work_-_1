int number1;
int number2;
int number3;
int max;
Console.WriteLine("Введите два числа ");
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
 {
    max = number1;
 }
else
 {
    max = number2;
 }
if (max > number3)
 {
    Console.WriteLine("{0} наибольшее число ", max);
 }
else
 {
    Console.WriteLine("{0} наибольшее число ", number3);
 }