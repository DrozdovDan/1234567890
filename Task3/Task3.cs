using System.Diagnostics;

namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x) => x < 0 ? 0.0 : Math.Floor(x) % 2 == 0 ? 1.0 : -1.0;

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) ? 366 : 365;

/*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            char rotate1(char orientation, int cmd) => 
                cmd == 1 ? 
                    orientation == 'Ю' ? 'В' :
                    orientation == 'В' ? 'С' :
                    orientation == 'С' ? 'З' :
                    orientation == 'З' ? 'Ю' : ' ' :
                cmd == -1 ?
                    orientation == 'Ю' ? 'З' :
                    orientation == 'В' ? 'Ю' :
                    orientation == 'С' ? 'В' :
                    orientation == 'З' ? 'С' : ' ' :
                cmd == 2 ? 
                    orientation == 'Ю' ? 'С' :
                    orientation == 'В' ? 'З' :
                    orientation == 'С' ? 'Ю' :
                    orientation == 'З' ? 'В' : ' ' : ' ' ;

            return rotate1(rotate1(orientation, cmd1), cmd2);
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            var firstNum = age / 10;
            var secondNum = age % 10;
            string firstWord = "";
            switch (firstNum)
            {
                case 2:
                    firstWord = "двадцать";
                    break;
                case 3:
                    firstWord = "тридцать";
                    break;
                case 4:
                    firstWord = "сорок";
                    break;
                case 5:
                    firstWord = "пятьдесят";
                    break;
                case 6:
                    firstWord = "шестьдесят";
                    break;
            }

            switch (secondNum)
            {
                case 0:
                    return $"{firstWord} лет";
                case 1:
                    return $"{firstWord} один год";
                case 2:
                    return $"{firstWord} два года";
                case 3:
                    return $"{firstWord} три года";
                case 4:
                    return $"{firstWord} четыре года";
                case 5:
                    return $"{firstWord} пять лет";
                case 6:
                    return $"{firstWord} шесть лет";
                case 7:
                    return $"{firstWord} семь лет";
                case 8:
                    return $"{firstWord} восемь лет";
                case 9:
                    return $"{firstWord} девять лет";
            }

            return "";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(11));
            Console.WriteLine(NumberOfDays(2022));
            Console.WriteLine(Rotate2('С', 1, 2));
            Console.WriteLine(AgeDescription(45));
        }
    }
}