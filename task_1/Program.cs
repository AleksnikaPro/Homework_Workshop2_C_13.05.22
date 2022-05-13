// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if(number == 6 || number == 7)
{
    Console.WriteLine($"Введеный номер дня недели {number} является выходным");
}
else
{
    Console.WriteLine($"Введеный номер дня недели {number} является рабочим");
}