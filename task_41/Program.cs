Console.WriteLine("Программа котрая подсчитывает кличество отрицательных элементов, введенных с клавиатуры");
Console.WriteLine("Введите элементы массива через пробел");

int [] numbers = Console.ReadLine().Split().Select( x=> Convert.ToInt32(x)).ToArray();

int schet = 0;

for (int i=0; i<= numbers.Length-1; i++)
{
    if (numbers[i]<0) {schet++;}
}

Console.WriteLine($"Количество отрицательных элементов = {schet}");