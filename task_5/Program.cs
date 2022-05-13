// Найти расстояние между точками в пространстве 3D.

Console.WriteLine("Давайте найдем расстояние между точками А и В в пространстве 3D");

Console.WriteLine("Введите координату X для точки А: ");
int AnumX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки А: ");
int AnumY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки А: ");
int AnumZ = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B: ");
int BnumX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B: ");
int BnumY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки B: ");
int BnumZ = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(BnumX - AnumX,2) + Math.Pow(BnumY - AnumY,2) + Math.Pow(BnumZ - AnumZ,2));
Console.WriteLine($"Расстояние между точками А и В в пространстве 3D равно {result}");


