using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Exercises
    {
        public static string getArray(int[] arr, int n) {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < n - 1; i++)
                res.Append(arr[i] + ", ");
            res.Append(arr[n - 1]);

            return res.ToString();
        }

        public static string exercise1(int[] arr, int n)
        {
            StringBuilder res = new StringBuilder();
            int max = arr[0];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            if (index != 0 || index != n - 1)
            {
                double sum = 0;
                double product = 1;

                for (int i = 0; i < n; i++)
                {
                    if (i < index) product *= arr[i];
                    else if (i > index) sum += arr[i];
                }

                res.Append("Product of elements before Max: " + product +
                    "\nSum of elements after Max: " + sum +
                    "\nResult: " + product / sum);
            }
            else res.Append("Can't find result! The max is the first or last element in the array.");

            return res.ToString();
        }

        public static string exercise2(int[] arr, int n)
        {
            StringBuilder res = new StringBuilder();
            int index = -1;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > 0 && arr[i + 1] > 0)
                    if (arr[i] == arr[i + 1]) index = i;
            }

            if (index != -1)
            {
                res.Append("Deleted element: " + arr[index]);
                for (int i = index; i < n - 2; i++)
                    arr[i] = arr[i + 2];

                res.Append("\nModified Array: \n");
                res.Append(getArray(arr, n - 2));
            }
            else res.Append("There're no 2 consecutive positive elements in the array!");

            return res.ToString();
        }

        public static string exercise3(int[] arr, int n, int num)
        {
            StringBuilder res = new StringBuilder();

            int index = -1;
            for (int i = 0; i < n; i++)
                if (arr[i] < 0) index = i;

            if (index != -1)
            {
                n += 2;
                index += 2;
                for (int i = n; i >= index; i--)
                    arr[i] = arr[i - 2];
                arr[index - 1] = num;
                arr[index] = num;


                res.Append("\nModified Array: \n");
                res.Append(getArray(arr, n));
            }
            else res.Append("There's no negative numbers in the array.");

            return res.ToString();
        }

        public static string exercise4(int[] arr, int n)
        {
            StringBuilder res = new StringBuilder();
            bool contains = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    contains = true;
                    break;
                }
            }

            if (contains) res.Append("There's positive numbers in the array.");
            else res.Append("There's NO positive numbers in the array.");

            return res.ToString();
        }
    }
}
