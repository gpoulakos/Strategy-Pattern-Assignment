using StrategyPatternAssignment.Database;
using StrategyPatternAssignment.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();

            Console.WriteLine("Below you can see the collection of clothes of our shop, sorted by Color, Fabric and Size!!");
            Console.WriteLine();
            var shirts1 = db.Shirts;
            #region BubbleSort

            // ======================= Bubble Sort for Size ======================= //

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Ascending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Descending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeDesc(shirts1);
            PrintAllItems(shirts1);

            // ======================= Bubble Sort for Colors ======================= //

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Ascending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.ColorAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Descending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.ColorDesc(shirts1);
            PrintAllItems(shirts1);

            // ======================= Bubble Sort for Fabric ======================= //

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Ascending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.FabricAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Descending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.FabricDesc(shirts1);
            PrintAllItems(shirts1);

            // ======================= Bubble Sort for SizeColorFabric ======================= //

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("SizeColorFabric Ascending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeColorFabricAsc(shirts1);
            PrintAllItems(shirts1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("SizeColorFabric Descending with BubbleSort");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            BubbleSort.SizeColorFabricDesc(shirts1);
            PrintAllItems(shirts1);

            #endregion

            var shirts = db.Shirts.ToArray();

            #region QuickSort
            // ======================= Quick Sort for Colors======================= //

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.ColorAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            Console.WriteLine("=================================================");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Color Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.ColorDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            // ======================= Quick Sort for Size ======================= //

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.SizeAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            Console.WriteLine("=================================================");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Size Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.SizeDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            // ======================= Quick Sort for Fabric ======================= //

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.FabricAsc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            Console.WriteLine("=================================================");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Fabric Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            QuickSort.FabricDesc(shirts, 0, shirts.Length - 1);
            PrintAllItems(shirts);

            #endregion


            #region BucketSort

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Size Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listsize1 = BucketSort.SortbySizeAsc(shirts);
            PrintAllItems(listsize1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Size Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listsize2 = BucketSort.SortbySizeDesc(shirts);
            PrintAllItems(listsize2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Color Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listcolor1 = BucketSort.SortbyColorAsc(shirts);
            PrintAllItems(listcolor1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Color Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listcolor2 = BucketSort.SortbyColorDesc(shirts);
            PrintAllItems(listcolor2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Fabric Ascending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listfabric1 = BucketSort.SortbyFabricAsc(shirts);
            PrintAllItems(listfabric1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Bucket by Fabric Descending");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            var listfabric2 = BucketSort.SortbyFabricDesc(shirts);
            PrintAllItems(listfabric2);

            #endregion

            

            //EshopApplication.Checkout();
            Console.ReadKey();
        }

        public static void PrintAllItems(IEnumerable<Shirt> shirts)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("All Clothes");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Color", "Size", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in shirts)
            {
                item.Output();
            }

        }
    }
}


