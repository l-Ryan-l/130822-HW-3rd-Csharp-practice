// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!);

void Cube(int[] userNumber)
{
  int length = userNumber.Length;
  int index = 0;
  while (index < length)
  {
    userNumber[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}

void PrintArray(int[] output)
{
  int count = output.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(output[index]+ " ");
    index++;
  }
} 

int[] array = new int[userNumber + 1];
Cube(array);
PrintArray(array);