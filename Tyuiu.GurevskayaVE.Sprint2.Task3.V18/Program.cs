using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GurevskayaVE.Sprint2.Task3.V18.Lib;

namespace Tyuiu.GurevskayaVE.Sprint2.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Гурьевская В.Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Гурьевская В.Е. | ПКТб-23-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение Y с            *");
            Console.WriteLine("* использование вложенных операторов if - else, где пользователь вводит   *");
            Console.WriteLine("* значение переменной х с клавиатуры.                                     *");
            Console.WriteLine("* Округлить до 3 знаков после запятой.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* y = x**2(((x+1)/(x-1)))**2 (x>1)                                        *");
            Console.WriteLine("* y = (x**2-cos(x)**2+10)/(x**2-sin(x)**2+12) (x=0)                       *");
            Console.WriteLine("* y = (1+1/x**2)**x (-22<x<2)                                             *");
            Console.WriteLine("* y = x+10x-(1/x) (x<-22)                                                 *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции: " + ds.Calculate(x));

            Console.ReadKey();
        }
    }
}
