//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
Console.Clear();

System.Console.Write("Сколько слов вы будете вводить?(число от 1 до 100):");
int dlin = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int Length = 100)
{
    string[] startArray = new string[dlin];
    for (int i = 0; i < dlin; i++)
    {
        System.Console.Write($"Введите {i+1} слово: ");
        startArray[i] = Console.ReadLine();
    }
    return startArray;
}

string[] GetItogArray(string[] array)
{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
	
	for (int i = 0; i < length; i++)
	{
		if(array[i].Length <= 3)
		{
			result[count] = array[i];
			count++;
		}
	}
	Array.Resize(ref result, count);
			
	return result;
}

void printArray(string[] array)
{
	{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}

void printItog(string[] array)
{
	Console.WriteLine("Изначальный массив:");
	printArray(array);
	string[] shortArray = GetItogArray(array);
	Console.WriteLine("Итоговый массив (из слов содержащие 3 или меньше символов)");
	printArray(shortArray);
	Console.WriteLine();
} 

printItog(CreateArray());