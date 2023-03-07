
//сортировка вставками: отсортировать одномерный массив методом вставки

Console.WriteLine("Введите размерность одномерного массива");
int razmer = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводите эелементы массив по одному");
int[] array = new int[razmer];

for (int i = 0; i < razmer; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int a;

for (int i = 0; i < razmer; i++)
{
    while (array[i] < array[i+1])
    {
        a = array[i];
        array[i] = array[i+1];
        array[i+1] = a;
    }
}

Console.WriteLine("Итог");

for(int i = 0; i < razmer; i++)
{
    Console.WriteLine(array[i]);
}
Console.ReadLine();
