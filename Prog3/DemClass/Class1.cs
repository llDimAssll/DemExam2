using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemClass
{
    public class Class1
    {
        /// <summary>
        /// Вычисляет корни квадратного уравнения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Результат вычисления кода</returns>

        public static string SquareMetod(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"Корень x1 = {x1} x2 = {x2}";
            }
            else if (d == 0)
            {
                double x1 = -b / (2 * a);
                return $"Корень x = {x1}";
            }
            else
            {
                return "Корней нет";
            }
        }

        public static string LinenUr(double k, double b)
        {
            if (k == 0 & b != 0) return "Нет корней";
            if (k == 0 & b == 0) return "Бесконечное количество корней";
            var x = (-k) / b;
            return $"Корень - {x}";
        }
    }
}
