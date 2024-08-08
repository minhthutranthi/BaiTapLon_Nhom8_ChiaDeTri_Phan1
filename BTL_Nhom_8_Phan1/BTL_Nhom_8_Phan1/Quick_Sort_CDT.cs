using System;

namespace BTL_Nhom_8_Phan1
{
    internal class Quick_Sort_CDT
    {

        public static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);


                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }
        }


        private static int Partition(int[] array, int left, int right)
        {
            int pivotValue = array[right];
            int l = left;
            int r = right - 1;

            while (l <= r)
            {
                while (l <= r && array[l] < pivotValue) l++;
                while (l <= r && array[r] > pivotValue) r--;

                if (l <= r)
                {
                    Swap(array, l, r);
                    l++;
                    r--;
                }
            }


            Swap(array, l, right);
            return l;
        }


        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        static void Main()
        {
            int[] array = { 7, 5, 2, 10, 11, 18, 16, 8, 1, 55, 3, 87, 56 };
            Console.WriteLine("Mang ban dau: " + string.Join(", ", array));


            Sort(array, 0, array.Length - 1);

            Console.WriteLine("Mang da sap xep : " + string.Join(", ", array));
        }
    }
}
