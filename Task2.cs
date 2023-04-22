using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_dz
{
    class Shop
    {
        private double _area;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public static Shop operator +(Shop shop, double area)
        {
            shop.Area += area;
            return shop;
        }

        public static Shop operator -(Shop shop, double area)
        {
            shop.Area -= area;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return !(shop1 == shop2);
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Shop shop = (Shop)obj;
            return Area == shop.Area;
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
    }
    internal class Task2
    {
        public static void task2()
        {
            Shop shop1 = new Shop();
            shop1.Area = 50.5;

            Shop shop2 = new Shop();
            shop2.Area = 30.2;

            // Додавання площі до магазину
            shop1 += 10.0;
            Console.WriteLine($"Площа магазину 1: {shop1.Area}");

            // Віднімання площі від магазину
            shop2 -= 5.0;
            Console.WriteLine($"Площа магазину 2: {shop2.Area}");

            // Порівняння магазинів
            if (shop1 > shop2)
            {
                Console.WriteLine("Площа магазину 1 більша, ніж площа магазину 2");
            }
            else if (shop1 < shop2)
            {
                Console.WriteLine("Площа магазину 2 більша, ніж площа магазину 1");
            }
            else if (shop1 == shop2)
            {
                Console.WriteLine("Площа магазину 1 та магазину 2 однакова");
            }

            Console.ReadLine();
        }
    }
}
