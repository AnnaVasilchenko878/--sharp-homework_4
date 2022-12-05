// Напишите цикл, который принимает на вход два числа (A и В) и возводит число А в натуральную степень В
// 3,5->243
// 2,4->16

void NumPow (int number, int degree)
{
  int result =1;
  for(int i=1; i<=degree; i++)
  {
    result= result*number; 
  }
  Console.WriteLine(result);
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());
NumPow(number, degree);

