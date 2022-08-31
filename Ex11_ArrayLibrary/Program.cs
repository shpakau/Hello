void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если нет элемента, то так

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // останавливает поиск на первом найденном
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // инициализация массива равного 10

FillArray(array); // заполнить массив
array[4] = 4; // добавили 4 если сам массив не сфомирует ее
array[6] = 4;

PrintArray(array); // распечатать массив
Console.WriteLine();

int pos = IndexOf(array, 444); // место в созданном массиве
Console.WriteLine(pos);