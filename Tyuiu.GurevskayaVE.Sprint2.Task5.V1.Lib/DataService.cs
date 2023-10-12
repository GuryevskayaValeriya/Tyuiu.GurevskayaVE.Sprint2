using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GurevskayaVE.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res;
            switch (value)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    res = 31;
                    break;
                case 2:
                    res = 28;
                    break;
                case 4: case 6: case 9: case 11:
                    res = 30;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
            }
            return res;
        }
    }
}
