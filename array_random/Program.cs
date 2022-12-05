// Напишите программу, которая задает массив из 8-ми элементов и выводит  их на экран

int [] array = new int [8];

void PushArray(int [] array)
{
  for(int i=0; i<array.Length; i++)
  {
    array[i] = new Random().Next(0, 1000);
  }
}
void PrintArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine(array[i]);
  }
}
PushArray(array);
PrintArray(array);