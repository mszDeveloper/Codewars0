using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Codewars0
{
    class Kata1
    {
        public static string Likes(string[] name)
        {
            string displayText = String.Empty;
            string oneLikeText = " likes this";
            string likeText = " like this";
            string noOneLikesText = "no one" + oneLikeText;
            int othersNamesCount = 4;
            if (name.Length.Equals(0))
            {
                displayText = noOneLikesText;
            }
            if (name.Length.Equals(1))
            {
                displayText = name.First() + oneLikeText;
            }
            if (name.Length.Equals(2))
            {
                displayText = name.First() + " and " + name.Last() + likeText;
            }
            if (name.Length.Equals(3))
            {
                displayText = name.First() + ", " + name[1] + " and " + name.Last() + likeText;
            }
            if (name.Length >= othersNamesCount)
            {
                displayText = name.First() + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others" + likeText;
            }
            return displayText;
        }

        public static int MaxSequence(int[] arr)
        {
            int maxSum = 0;
            int currentSum = 0;
            foreach (var item in arr)
            {
                currentSum += item;
                currentSum = Math.Max(currentSum, 0);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }

        public class DigPow
        {
            public static long digPow(int n, int p)
            {
                string digits = n.ToString();
                double sum = 0;
                int add = 0;
                foreach (var item in digits)
                {
                    double digit = Char.GetNumericValue(item);
                    sum += Math.Pow(digit, p + add);
                    add++;
                }
                if (!(sum % n).Equals(0)) return -1;
                return Convert.ToInt64(sum / n);
            }
        }

        public class SumDigPower
        {

            public static long[] SumDigPow(long a, long b)
            {
                List<long> numbers = new();
                for (var number = a; number <= b; number++)
                {
                    string digits = number.ToString();
                    if (digits.Length.Equals(1))
                    {
                        numbers.Add(number);
                        continue;
                    }
                    double sum = 0;
                    double power = 1;
                    foreach (var item in digits)
                    {
                        sum += Math.Pow(Char.GetNumericValue(item), power);
                        power++;
                    }
                    if (sum.Equals(number))
                    {
                        numbers.Add(number);
                    }
                }
                return numbers.ToArray();
            }
        }

        public class StripCommentsSolution
        {
            public static string StripComments(string text, string[] commentSymbols)
            {
                string[] lines = text.Split(new[] { "\n" }, StringSplitOptions.None);
                lines = lines.Select(x => x.Split(commentSymbols, StringSplitOptions.None).First().TrimEnd()).ToArray();
                return string.Join("\n", lines);
            }
        }

        public class Matrix
        {
            public static double[] Gauss(double[,] Matrix)
            {
                int n = Matrix.GetLength(0); //Размерность начальной матрицы (строки)
                double[,] Matrix_Clone = new double[n, n + 1]; //Матрица-дублер
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n + 1; j++)
                        Matrix_Clone[i, j] = Matrix[i, j];

                // Прямой ход (Зануление нижнего левого угла)
                for (int k = 0; k < n; k++) //k-номер строки
                {
                    for (int i = 0; i < n + 1; i++) //i-номер столбца
                        Matrix_Clone[k, i] = Matrix_Clone[k, i] / Matrix[k, k]; //Деление k-строки на первый член !=0 для преобразования его в единицу
                    for (int i = k + 1; i < n; i++) //i-номер следующей строки после k
                    {
                        double K = Matrix_Clone[i, k] / Matrix_Clone[k, k]; //Коэффициент
                        for (int j = 0; j < n + 1; j++) //j-номер столбца следующей строки после k
                            Matrix_Clone[i, j] = Matrix_Clone[i, j] - Matrix_Clone[k, j] * K; //Зануление элементов матрицы ниже первого члена, преобразованного в единицу
                    }
                    for (int i = 0; i < n; i++) //Обновление, внесение изменений в начальную матрицу
                        for (int j = 0; j < n + 1; j++)
                            Matrix[i, j] = Matrix_Clone[i, j];
                }

                // Обратный ход (Зануление верхнего правого угла)
                for (int k = n - 1; k > -1; k--) //k-номер строки
                {
                    for (int i = n; i > -1; i--) //i-номер столбца
                        Matrix_Clone[k, i] = Matrix_Clone[k, i] / Matrix[k, k];
                    for (int i = k - 1; i > -1; i--) //i-номер следующей строки после k
                    {
                        double K = Matrix_Clone[i, k] / Matrix_Clone[k, k];
                        for (int j = n; j > -1; j--) //j-номер столбца следующей строки после k
                            Matrix_Clone[i, j] = Matrix_Clone[i, j] - Matrix_Clone[k, j] * K;
                    }
                }

                // Отделяем от общей матрицы ответы
                double[] Answer = new double[n];
                for (int i = 0; i < n; i++)
                    Answer[i] = Matrix_Clone[i, n];

                return Answer;
            }

            public static int Determinant(int[][] matrix)
            {
                // Your code here!
                return 0;
            }
        }


















    }
}
