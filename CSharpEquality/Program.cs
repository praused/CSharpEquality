using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] list =
            {
                new Food("apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new CookedFood("baked", "apple", FoodGroup.Fruit)};
            SortAndShowList(list);

            Food[] list2 =
            {
                new CookedFood("baked", "apple", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit)};
            Console.WriteLine();
            SortAndShowList(list2);
              
        }

        static void SortAndShowList(Food[] list)
        {
            Array.Sort(list, FoodNameComparer.Instance);

            foreach (var item in list) Console.WriteLine(item);
        }
    }
}
