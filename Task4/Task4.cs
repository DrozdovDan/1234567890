namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1) 
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        if (j == 0 || j == width - 1)
                        {
                            Console.Write(frameChar);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.Write('\n');
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            while (i < height)
            {
                int j = 0;
                while (j < width)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write(frameChar);
                    }
                    else
                    {
                        if (j == 0 || j == width - 1)
                        {
                            Console.Write(frameChar);
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    j++;
                }
                Console.Write('\n');
                i++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a >= b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            return b + a;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double Factorial(double n) => n > 0 ? n * Factorial(n - 1) : n == 0 ? 1 : 0;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, i) / Factorial(i);
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(14, 49));
            Console.WriteLine(ExpTaylor(11, 3));
        }
    }
}