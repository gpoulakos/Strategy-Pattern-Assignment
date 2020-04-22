using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAssignment.SortingAlgorithms
{
    class QuickSort
    {
        public static int partitionColorAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Color < pivot.Color)
                {
                    i++;

                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionColorDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Color > pivot.Color)
                {
                    i++;
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static void ColorAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionColorAsc(arr, low, high);

                ColorAsc(arr, low, pi - 1);
                ColorAsc(arr, pi + 1, high);
            }
        }
        public static void ColorDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionColorDesc(arr, low, high);

                ColorDesc(arr, low, pi - 1);
                ColorDesc(arr, pi + 1, high);
            }
        }

        public static int partitionSizeAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Size < pivot.Size)
                {
                    i++;
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionSizeDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Size > pivot.Size)
                {
                    i++;

                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void SizeAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionSizeAsc(arr, low, high);

                SizeAsc(arr, low, pi - 1);
                SizeAsc(arr, pi + 1, high);
            }
        }
        public static void SizeDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionSizeDesc(arr, low, high);

                SizeDesc(arr, low, pi - 1);
                SizeDesc(arr, pi + 1, high);
            }
        }


        public static int partitionFabricAsc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Fabric < pivot.Fabric)
                {
                    i++;

                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
        public static int partitionFabricDesc(Shirt[] arr, int low, int high)
        {
            Shirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j].Fabric > pivot.Fabric)
                {
                    i++;

                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void FabricAsc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionFabricAsc(arr, low, high);

                FabricAsc(arr, low, pi - 1);
                FabricAsc(arr, pi + 1, high);
            }
        }
        public static void FabricDesc(Shirt[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionSizeDesc(arr, low, high);

                FabricDesc(arr, low, pi - 1);
                FabricDesc(arr, pi + 1, high);
            }
        }
    }
}
