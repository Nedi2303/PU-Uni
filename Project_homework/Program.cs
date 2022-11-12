// задача 87 д)

//int n = int.Parse(Console.ReadLine());
//for (int row = 1; row <= n; row++)
//{
//    int spaces = n - row;
//    for (int count = 0; count < spaces; count++)
//    {
//        Console.Write(" ");
//    }

//    for (int col = 1; col <= row; col++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}

// задача 37

//int q = int.Parse(Console.ReadLine());
//int p = int.Parse(Console.ReadLine());
//int r = int.Parse(Console.ReadLine());

//bool result = (q / p + r) - (3 * q) != 5 * p && p >= r;
//Console.WriteLine(result);


// Тест 1; 7. 1гр


//double H = double.Parse(Console.ReadLine());
//double R = double.Parse(Console.ReadLine());
//double r = double.Parse(Console.ReadLine());

//double V = Math.PI * H * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2)) / 3;

//Console.WriteLine(V);


// задача 162

// a)
//static double Cor(int x, int y)
//{
//    int result = 0;
//    if (x != -y || Cor(x, y) == 0)
//    {
//        result = Math.Abs(x) * Math.Abs(y) / (x + y);
//    }
//    return result;
//}

//// b)
//int p, q;

//do
//{
//    Console.Write("p= ");
//    p = int.Parse(Console.ReadLine());
//} while (p < -30 || p > 30);

//do
//{
//    Console.Write("q= ");
//    q = int.Parse(Console.ReadLine());
//} while (q < -30 || q > 30);

//// c)
//Console.WriteLine($"Резултат= {Cor(p, 3 * q) - Cor(3 * p, q) / Cor(p, q)}");

//// d)
//for (p = -30; p < 30; p += 3)
//{
//    double s = Cor(p, q);
//    if (s - (int) s == 0 && (int) s % 2 == 0)
//    {
//        Console.WriteLine($"Cor(p, q)= {s}");
//    }
//}
