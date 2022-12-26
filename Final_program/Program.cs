//  ввод и вывод данных
Console.Write("Количество введеных элементов?");
int size = Convert.ToInt32(Console.ReadLine());

// Обьявление и инициализация переменной
// массив строк
string[] arrl = new string[size];
int length = 3;
int position = 0;

// обработка переданных данных, пока переменная i меньше size мы выводим параметры, цикл for
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= length)
    {
        arrl[position] = element;
        position++;
    }
}

Console.WriteLine();
PrintArray(arrl);

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}