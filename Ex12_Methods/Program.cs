// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
// Method21(msg: "Текс", count: 5);
Method21(count: 4, msg: "Новый текст");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4
// string Method4(int count, string text)
string Method4(int count, string text)
{
   int i = 0;
  string result = String.Empty;
 while (i < count)
    {
        result = result + text;
        i ++;
    }
    return result;
}
 string res = Method4(7, "asdr_76");
 Console.WriteLine(res);

// Вид 4_1
// цикл for
string Method41(int count, string text)
{
    
    string result = String.Empty;
    for( int i = 0; i < count; i++)
     {
        result = result + text;
       
    }
    return result;
}
string res1 = Method41(4, "asdr_79");
Console.WriteLine(res1);

// таблица умножения
for (int i = 2; i <= 10; i ++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//// ==== Работа с текстом
// Дан текст. В тексте нужно все пробелы замменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(text, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(text, 'С', 'с');
Console.WriteLine(newText2);

//// Массив
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for ( int k = 0; k < count; k++ )
    {
        Console.Write($"{array[k]}");
    }
    Console.WriteLine();
}
// метод упорядывающий массив
void SelectionSort(int[] array)
{
    for (int k = 0; k < array.Length - 1 ; k++)
    {
        int minPosition = k;

        for (int j = k + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                 minPosition = j;
            }
        }
        int temporary = array[k];
        array[k] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

// обратный порядок
// метод упорядывающий массив
// void SelectionSortMax(int[] array)
{
    for (int f = 0; f > array.Length - 1 ; f--)
    {
        int maxPosition = f;

        for (int s = f + 1; s > array.Length; s--)
        {
            if(array[s] > array[maxPosition])
            {
                 maxPosition = s;
            }
        }
        int temporary = array[f];
        array[f] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
// PrintArray(arr);
// SelectionSortMax(arr);

//PrintArray(arr);