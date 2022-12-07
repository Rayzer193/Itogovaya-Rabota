//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
System.Console.Write("Сколько строк вы будете вводить?(число от 1 до 100):");
int dlin = Convert.ToInt32(Console.ReadLine());

void printArray(string[] array)
{
	if(array.Length == 0)
	{
		Console.WriteLine("Array is empty");
	}
	else
	{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}