// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
//k1 * x -y + b1 = 0
//k2 * x - y + b2 =0
//k2 * x - k1 * x - b1 + b2 = 0
// x = (b1 - b2)/(k2 - k1)
// y = k1 * (b1 - b2)/(k2 - k1) + b1
Double k1 = new Random().Next(1,10);
Double b1 = new Random().Next(1,10);
Double k2 = new Random().Next(1,10);
Double b2 = new Random().Next(1,10);
Double x = (b1 - b2)/(k2 - k1);
Double y = k1 * (b1 - b2)/(k2 - k1) + b1;
if (k1 == k2) Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
if (k1 / k2 == 1 / 1) Console.WriteLine("Прямые совпадают ");
Console.WriteLine($"k1 = {k1}; b1 = {b1}; k2 = {k2}; b2 = {b2};");
Console.WriteLine($"точкa пересечения двух прямых: ({x};{y})");
