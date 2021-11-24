using System;

namespace lab9
{
    //Task 1
    //public delegate void Fun();
    //class TestMain
    //{
    //    private static void Calc()
    //    {
    //        Console.Write("Введiть нижню межу = ");
    //        double a = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Введiть верхню межу = ");
    //        double b = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Введiть кiлькiсть вiдрiзкiв, на яку розбивається iнтеграл = ");
    //        int n = Convert.ToInt16(Console.ReadLine());
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    //    }
    //    public static void Main()
    //    {
    //        Fun x = new Fun(Calc);
    //        x();
    //        Console.WriteLine();
    //    }
    //}

    //Task 2
    //public delegate double Fun(double a, double b, int n);
    //class TestMain
    //{
    //    private static double Calc(double a, double b, int n)
    //    {
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        return Math.Round(res, 3);
    //    }
    //    public static void Main()
    //    {
    //        Fun x = new Fun(Calc);
    //        Console.WriteLine($"Вiдповiдь: {x(2, 5, 3)}");
    //        Console.WriteLine();
    //    }
    //}

    //Task 3
    //public delegate void Fun(double a, double b, int n);
    //class TestMain
    //{
    //    private static void Calc(double a, double b, int n)
    //    {
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    //    }
    //    private static void Input(double a, double b, int n)
    //    {
    //        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
    //    }
    //    public static void Main()
    //    {
    //        Fun x = new Fun(Input);
    //        Fun y = new Fun(Calc);
    //        x += y;
    //        x(2.15, 4.99, 3);
    //        x += x;
    //        x(0.5, 3, 5);
    //        x -= y; x -= y; x -= y;
    //        x(1.25, 4.8, 5);
    //        Console.WriteLine();
    //    }
    //}

    //Task 4
    //public delegate void Fun(double a, double b, int n);
    //class Trapezium
    //{
    //    public void Calc(double a, double b, int n)
    //    {
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    //    }
    //    public void Input(double a, double b, int n)
    //    {
    //        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
    //    }
    //}
    //class TestMain
    //{
    //    static void Main()
    //    {
    //        Trapezium a = new Trapezium();
    //        Fun f = new Fun(a.Input);
    //        f += new Fun(a.Calc);
    //        f(2, 5, 5);
    //        Console.WriteLine();
    //    }
    //}

    //Task 5
    //delegate void Fun(double a, double b, int n);
    //class Trap
    //{
    //    private bool Check(double a, double b, int n)
    //    {
    //        if (a >= b)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //    public void Input(int n, Fun f)
    //    {
    //        for (int a = 2; a < n; a += a)
    //        {
    //            for (int b = 2; b < n; b++)
    //            {
    //                for (int c = 2; c < n; c += c)
    //                {
    //                    if (Check(a, b, c) == true)
    //                    {
    //                        f(a, b, c);
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    public void Calc(double a, double b, int n)
    //    {
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    //    }
    //}
    //class TestMain
    //{
    //    public static void Calc(double a, double b, int n)
    //    {
    //        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
    //        Trap x = new Trap();
    //        x.Calc(a, b, n);
    //    }
    //    public static void Main()
    //    {
    //        Trap x = new Trap();
    //        Fun fun = new Fun(TestMain.Calc);
    //        x.Input(7, fun);
    //        Console.WriteLine();
    //    }
    //}

    //Task 6
    //delegate void Action();
    //class AlarmClock
    //{
    //    public event Action Alarm;
    //    public void Start(int count)
    //    {
    //        for (int i = 0; i < count; ++i) { }
    //        if (Alarm != null)
    //        {
    //            Alarm();
    //        }
    //    }
    //    public void Calc(double a, double b, int n)
    //    {
    //        double h, x1, x2, res, sum = 0;
    //        h = (b - a) / n;
    //        for (int i = 0; i < n; i++)
    //        {
    //            x1 = a + i * h;
    //            x2 = a + (i + 1) * h;
    //            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
    //        }
    //        res = sum * h / 2;
    //        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    //    }
    //}
    //class TestMain
    //{
    //    public static void WakeUp()
    //    {
    //        Console.WriteLine("Завантаження...");
    //    }
    //    public static void Main()
    //    {
    //        AlarmClock clk = new AlarmClock();
    //        clk.Alarm += new Action(WakeUp);
    //        Random rand = new Random();
    //        for (int i = 0; i < 6; i++)
    //        {
    //            clk.Start(199999999);
    //            clk.Calc(rand.Next(1, 10), rand.Next(2, 10), 3);
    //            Console.WriteLine();
    //        }
    //    }
    //}
}
