using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Date
    {
        public int Day;
        public int Month;
        public double Age;

        public Date(int Day, int Month, double Age)
        {
            this.Day = Day;
            this.Month = Month;
            this.Age = Age;
        }

        public bool Leap(double Age)
        {
            if (Age % 4 == 0)
                return true;
            else
                return false;
        }

        public void Preday(int Day, int Month, double Age)
        {
            int pday = Day - 1;
            int pmonth = 0; double page = 0;
            if (pday <= 0)
            {
                pday = 30;
                pmonth = Month - 1;
            }
            else
                pmonth = Month;
            if (pmonth <= 0)
            {
                pmonth = 12;
                page = Age - 1;
            }
            else
                page = Age;
            Console.WriteLine("Предыдущий день: {0}.{1}.{2}", pday, pmonth, page);
        }
        public void Folday(int Day, int Month, double Age)
        {
            int fday = Day + 1;
            int fmonth = 0; double fage = 0;
            if (fday > 30)
            {
                fday = 1;
                fmonth = Month + 1;
            }
            else
                fmonth = Month;
            if (fmonth > 12)
            {
                fmonth = 1;
                fage = Age + 1;
            }
            else
                fage = Age;
            Console.WriteLine("Следующий день: {0}.{1}.{2}", fday, fmonth, fage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var date = new Date();
            Console.Write("Введите день: ");
            date.Day = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            date.Month = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            date.Age = double.Parse(Console.ReadLine());
            date.Folday(date.Day, date.Month, date.Age);
            date.Preday(date.Day, date.Month, date.Age);
            if (date.Leap(date.Age))
                Console.WriteLine("Год високостный");
            else
                Console.WriteLine("Год невисокостный");
            Console.ReadKey();
        }
    }
}
