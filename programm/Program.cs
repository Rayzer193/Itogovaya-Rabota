//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.
System.Console.Write("Сколько слов вы будете вводить?(число от 1 до 100):");
int dlin = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int Length = 100)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < dlin; i++)
    {
        System.Console.Write($"Введите {i+1} число: ");
        tempArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return tempArray;
}

void printArray(string[] array)
{
	{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}

string[] ItogArray= [];

void printItog(string[] array)
{
	Console.WriteLine("Изначальный массив:");
	printArray(array);
	string[] shortArray = ItogArray;
	Console.WriteLine("Итоговый массив (из слов содержащие 3 или меньше символов)");
	printArray(shortArray);
	Console.WriteLine();
}