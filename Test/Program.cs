/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

int size = 3;
string[] arrayStrings = new string[size];
int pos = 0;
for (int i = 0; i < size; i++)
{     
 Console.WriteLine("Введите элементы ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= 3)
  {
    arrayStrings[pos] = element;
    pos++;
  }
}
Console.WriteLine();
PrintArray(arrayStrings);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}