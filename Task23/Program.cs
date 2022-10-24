// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
 
Console.Write("Введите число: ");
int cube = int.Parse(Console.ReadLine()!);
 
void Cube(int[] cube)
{
  int index = 0;
  int length = cube.Length;
  while (index <  length)
  {
    cube[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}
 
void PrintArry(int[] number)
{
  int count = number.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(number[index]+ " ");
    index++;
  }
}
int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
