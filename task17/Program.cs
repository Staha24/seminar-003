// task17
Console.Write("Введите координату Х: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
    Console.Write( "1");
else if ( x < 0 && y > 0)
    Console.WriteLine("2");
else if (  x < 0 && y < 0)
    Console.WriteLine("3");
else 
    Console.WriteLine("4");   
