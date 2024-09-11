using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЯП2_Лаб1
{
    public static class Tasks
    {
        // Методы. Задание 1
        public static bool IsStringToDouble(string x)
        { 
            return double.TryParse(x, out var result);
        }

        public static double fraction(double x)
        {
            return (double)((decimal)x - Math.Truncate((decimal)x));          
        }
        // Методы. Задание 3
        public static bool IsStringToChar(string x)
        {
            return char.TryParse(x, out var result) && (char.Parse(x) >= 48 && char.Parse(x) <= 57);
        }
        public static int charToNum(char x)
        {
            return x - '0';
        }
        // Методы. Задание 5
        public static bool IsStringToInt(string x)
        {
            return int.TryParse(x, out var result);
        }
        public static bool is2Digits(int x)
        {
            return Math.Abs(x).ToString().Length == 2;
        }
        // Методы. Задание 7
        public static bool isInRange(int a, int b, int num)
        {
            return (num >= a && num <= b) || (num >= b && num <= a);
        }
        // Методы. Задание 9
        public static bool isEqual(int a, int b, int c)
        {
            return (a == b && a == c);
        }
        // Условия. Задание 1
        public static int abs(int x)
        {
            if (x >= 0)
                return x;
            else
                return -x;
        }
        // Условия. Задание 3
        public static bool is35(int x)
        {
            return (x % 3 == 0) ^ (x % 5 == 0);
        }
        // Условия. Задание 5
        public static int max3(int x, int y, int z)
        {
            if (x >= y && x >= z)
                return x;
            else if (y >= x && y >= z)
                return y;
            else 
                return z;
        }
        // Условия. Задание 7
        public static int sum2(int x, int y)
        {
            if (x + y >= 10 && x + y <= 19)
                return 20;
            else
                return x + y;
        }
        // Условия. Задание 9
        public static String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "It's not the day of the week";
            }
        }
        // Циклы. Задание 1
        public static bool IsStringToPositiveInt(string x)
        {
            return int.TryParse(x, out var result) && int.Parse(x) >= 0;
        }
        public static String listNums(int x)
        {
            String nums = String.Empty; 
            for (int i = 0; i <= x; i++)
            {
                nums += i.ToString() + ' ';
            }
            return nums;
        }
        // Циклы. Задание 3
        public static String chet (int x)
        {
            String nums = String.Empty;
            for (int i = 0; i <= x; i+=2)
            {
                nums += i.ToString() + ' ';
            }
            return nums;
        }
        // Циклы. Задание 5
        public static bool IsStringToLong(string x)
        {
            return long.TryParse(x, out var result);
        }
        public static int numLen(long x)
        {
            return x.ToString().Length;
        }
        // Циклы. Задание 7
        public static string square(int x)
        {
            string s = string.Empty;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    s += "*";
                }
                s += "\n";
            }
            return s;
        }
        // Циклы. Задание 9
        public static string rightTriangle(int x)
        {
            string s = string.Empty;
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j < x - i; j++)
                {
                    s += " ";
                }
                for (int k = 0; k <= i; k++)
                {
                    s += "*";
                }
                s += "\n";
            }
            return s;
        }
        // Массивы. Задание 1
        public static int[] StringToIntArr(string[] stringArr)
        {
            int[] intArr = new int[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);
            }
            return intArr;
        }
        public static string IntArrToString(int[] intArr)
        {
            string s = "";
            for (int i = 0; i < intArr.Length; i++)
            {
                s += intArr[i].ToString() + " ";
            }
            return s;
        }
        public static bool IsStringToIntArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!IsStringToInt(arr[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
        // Массивы. Задание 3
        public static int maxAbs(int[] arr)
        {
            int maxv = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxv))
                    maxv = arr[i];
            }
            return maxv;
        }
        // Массивы. Задание 5
        public static bool IndexNotOutside(string[] arr, string pos)
        {
            return IsStringToIntArray(arr) && IsStringToInt(pos)
                && int.Parse(pos) <= arr.Length && int.Parse(pos) >= 0;
        }
        public static int[] add(int[] arr, int[] ins, int pos)
        {
            int[] arr2 = new int[arr.Length + ins.Length];
            for (int i = 0, k = 0; i < arr.Length; i++, k++)
            {
                if (i == pos)
                {
                    for (int j = 0; j < ins.Length; j++, k++)
                        arr2[k] = ins[j];
                }
                arr2[k] = arr[i];
            }
            return arr2;
        }
        // Массивы. Задание 7
        public static int[] reverseBack(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
        // Массивы. Задание 9
        public static int[] findAll(int[] arr, int x)
        {
            int kol = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    kol++;
            }
            int[] arr2 = new int[kol];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr2[j] = i;
                    j++;
                }
            }
            return arr2;
        }
    }
}
