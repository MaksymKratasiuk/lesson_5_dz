using lesson_5_dz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_dz
{
    class Journal
    {
        private int _numOfWorkers;

        public int NumOfWorkers
        {
            get { return _numOfWorkers; }
            set { _numOfWorkers = value; }
        }

        public static Journal operator +(Journal journal, int numOfWorkers)
        {
            journal.NumOfWorkers += numOfWorkers;
            return journal;
        }

        public static Journal operator -(Journal journal, int numOfWorkers)
        {
            journal.NumOfWorkers -= numOfWorkers;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.NumOfWorkers == journal2.NumOfWorkers;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !(journal1 == journal2);
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.NumOfWorkers > journal2.NumOfWorkers;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.NumOfWorkers < journal2.NumOfWorkers;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Journal journal = (Journal)obj;
            return NumOfWorkers == journal.NumOfWorkers;
        }

        public override int GetHashCode()
        {
            return NumOfWorkers.GetHashCode();
        }
    }

    internal class Task1
    {
        public static void task1()
        {
            Journal journal1 = new Journal();
            journal1.NumOfWorkers = 5;

            Journal journal2 = new Journal();
            journal2.NumOfWorkers = 10;

            // Додавання до журналу
            journal1 += 3;
            Console.WriteLine($"Кількість працівників у журналі 1: {journal1.NumOfWorkers}");

            // Віднімання від журналу
            journal2 -= 5;
            Console.WriteLine($"Кількість працівників у журналі 2: {journal2.NumOfWorkers}");

            // Порівняння журналів
            if (journal1 > journal2)
            {
                Console.WriteLine("У журналі 1 більше працівників, ніж у журналі 2");
            }
            else if (journal1 < journal2)
            {
                Console.WriteLine("У журналі 2 більше працівників, ніж у журналі 1");
            }
            else if (journal1 == journal2)
            {
                Console.WriteLine("У журналі 1 та журналі 2 однакова кількість працівників");
            }

            Console.ReadLine();
        }
    }
}
