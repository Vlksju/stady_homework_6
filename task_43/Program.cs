Console.WriteLine("Программа котрая выдает точки пересечения двух прямых");

Console.Write("Угловой коэффициент 1ой прямой =  ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Угловой коэффициент 2ой прямо =  ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пересечение с оью у 1ой прямой =  ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Пересечение с оью у 2ой прямой =  ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if (k1==k2) {Console.Write("Прямые параллельны");}
else {x= (b2-b1)/(k1-k2);
y = k2*((b2-b1)/(k1-k2))+b2;
Console.WriteLine($"Кординаты точки пересечения ({x};{y})");
}

