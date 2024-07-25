namespace AC__ASS1
{
    internal class Program
    {
        public static void BuubleSort(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {

                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // Swap arr[j] and arr[j+1]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                        }else break;
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            /* The Bubble Sort algorithm has a time complexity  * of O(n^2) in its worst and average cases,
             * which * makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
              And implement the code of this optimized bubble sort algorithm*/
            #region Question1

            //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            //foreach (int i in array) {Console.WriteLine(i); }
            //Console.WriteLine("After sorting===================");
            //BuubleSort(array);
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            /* create a generic Range<T> class that represents a range of values from 
             * a minimum value to a maximum value. The range should support basic operations
             * such as checking if a value is within the range and determining the length of the range.Requirements*/
            #region Question2

            /*..1-Create a generic class named Range<T> where T represents the type of values*/
            /*..2-Implement a constructor that takes the minimum and maximum values to define the range.*/
            /*..3-Implement a method IsInRange(T value) that returns true if the given  value is within the range,
             * otherwise false.*/
            /*..4-Implement a method Length() that returns the length of the range (the difference 
             * between the maximum and minimum values).
                Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface
                to allow for comparisons.
    */
            ///ALL IN RANGE CLASS----------------------------
            #region CallingOfMethods
            //Range<int> range = new Range<int>(5, 10);
            //Console.WriteLine(range.InRange(7));
            //Console.WriteLine(range.InRange(15));
            //Range<double> doublerange=new Range<double>(5,10);
            //Console.WriteLine(doublerange.InRange(5.1));
            #endregion


            #endregion
        }
    }
}
