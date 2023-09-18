string txt;
do
{
    Console.WriteLine("выберите операцию.");
    Console.WriteLine("1. Сложить два числа.");
    Console.WriteLine("2. вычесть первое из второго.");
    Console.WriteLine("3. перемножить два числа.");
    Console.WriteLine("4. разделить первое на второе.");
    Console.WriteLine("5. возвести в степень N первое число.");
    Console.WriteLine("6. найти квадратный корень из числа.");
    Console.WriteLine("7. найти один процент от числа.");
    Console.WriteLine("8. найти факториал числа.");
    Console.WriteLine("9. выйти из программы.");
    txt = Console.ReadLine();
    Console.WriteLine("введите первое число.");
    string input1 = Console.ReadLine();
    int x = Convert.ToInt32(input1);
    Console.WriteLine("введите второе число.");
    string input12 = Console.ReadLine();
    int y = Convert.ToInt32(input12);
    if (txt == "1")
    {
        int result = x + y;
        Console.WriteLine("ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "2")
    {
        int result = x - y;
        Console.WriteLine("ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "3")
    {
        int result = x * y;
        Console.WriteLine("ответ:");
      
        Console.WriteLine(result);
    }
    else if (txt == "4")
    {
        int result = x / y;
        Console.WriteLine("ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "5")
    {
        double pow = Math.Pow(x, y);
        Console.WriteLine("ответ:");
        Console.WriteLine(pow);
    }
    else if (txt == "6")
    {
        double sprt = Math.Sqrt(x);
        Console.WriteLine("ответ:");
        Console.WriteLine(sprt);
    }
    else if (txt == "7")
    {
        int result = x * y / 100;
        Console.WriteLine("ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "8")
    {
        int number = x;
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("ответ:");
        Console.WriteLine(factorial);
    }
} while (txt != "9");