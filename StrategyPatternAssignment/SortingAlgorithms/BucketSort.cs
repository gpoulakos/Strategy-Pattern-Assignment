using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment.SortingAlgorithms
{
    class BucketSort
    {

        #region By Size
        public static List<Shirt> SortbySizeAsc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Size / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListSizeAsc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListSizeAsc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Size < input[j].Size)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        public static List<Shirt> SortbySizeDesc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Size / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListSizeDesc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListSizeDesc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Size > input[j].Size)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        #endregion

        #region By Color
        public static List<Shirt> SortbyColorAsc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Color)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Color / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListColorAsc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListColorAsc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Color < input[j].Color)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        public static List<Shirt> SortbyColorDesc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Color)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Color / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListColorDesc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListColorDesc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Color > input[j].Color)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        #endregion

        #region By Fabric
        public static List<Shirt> SortbyFabricAsc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Fabric)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Fabric / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListFabricAsc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListFabricAsc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Fabric < input[j].Fabric)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        public static List<Shirt> SortbyFabricDesc(params Shirt[] x)
        {
            List<Shirt> sortedArray = new List<Shirt>();

            int numOfBuckets = Enum.GetValues(typeof(Fabric)).Length;

            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Fabric / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = BubbleSortListFabricDesc(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }
        static List<Shirt> BubbleSortListFabricDesc(List<Shirt> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i].Fabric > input[j].Fabric)
                    {
                        Shirt temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
        #endregion

    }
}
