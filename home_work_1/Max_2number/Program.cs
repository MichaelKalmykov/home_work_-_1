int number1;
int number2;
Console.WriteLine("Введите два числа ");
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
 {
    Console.WriteLine("{0} наибольшее число", number1);
 }
else
 {
    Console.WriteLine("{0} наибольшее число ", number2);
 }
 
