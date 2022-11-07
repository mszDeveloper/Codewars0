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
            public static double[,] Gauss(double[,] Matrix)
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
                return Matrix;
            }

            static void MatrixDecompose(ref int[][] matrix, out int toggle)
            {
                // Разложение LUP Дулитла. Предполагается,
                // что матрица квадратная.
                int n = matrix.Length; // для удобства
                toggle = 1;
                for (int j = 0; j < n - 1; ++j) // каждый столбец
                {
                    double colMax = Math.Abs(matrix[j][j]); // Наибольшее значение в столбце j
                    int pRow = j;
                    for (int i = j + 1; i < n; ++i)
                    {
                        if (matrix[i][j] > colMax)
                        {
                            colMax = matrix[i][j];
                            pRow = i;
                        }
                    }
                    if (pRow != j) // перестановка строк
                    {
                        int[] rowPtr = matrix[pRow];
                        matrix[pRow] = matrix[j];
                        matrix[j] = rowPtr;
                        toggle = -toggle; // переключатель перестановки строк
                    }
                    for (int i = j + 1; i < n; ++i)
                    {
                        matrix[i][j] /= matrix[j][j];
                        for (int k = j + 1; k < n; ++k)
                            matrix[i][k] -= matrix[i][j] * matrix[j][k];
                    }
                } // основной цикл по столбцу j
            }

            public static int Determinant1(int[][] matrix)
            {
                if (matrix.Length.Equals(1))
                {
                    return matrix[0][0];
                }
                if (matrix.Length.Equals(2))
                {
                    return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
                }
                int toggle;
                MatrixDecompose(ref matrix, out toggle);
                int result = toggle;
                for (int i = 0; i < matrix.Length; i++)
                {
                    result *= matrix[i][i];
                }
                return result;
            }
            public static int[][] ToTriangle(int[][] matrix)
            {
                int n = matrix.GetLength(0);
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        double coeff = matrix[j][i] / matrix[i][i];
                        for (int k = i; k < n; k++)
                            matrix[j][k] -= Convert.ToInt32(matrix[i][k] * coeff);
                    }
                }
                return matrix;
            }

            public static int Determinant(int[][] matrix)
            {
                int matrixLength = matrix.Length;
                if (matrixLength.Equals(1))
                {
                    return matrix[0][0];
                }
                if (matrixLength.Equals(2))
                {
                    return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
                }
                int det = 0;
                int toggle = 1;
                for (int col = 0; col < matrixLength; col++)
                {
                    if (!matrix[0][col].Equals(0))
                    {
                        int minorDet = Determinant(CreateMinorMatrix(matrix, col));
                        Console.WriteLine(minorDet);
                        //det += matrix[0][col] * Determinant(CreateMinorMatrix(matrix, col)) * toggle;
                    }
                    toggle = -toggle;
                }
                return det;
            }

            public static int[][] CreateMinorMatrix(int[][] matrix, int minorColumn)
            {
                int matrixLength = matrix.Length;
                int[][] result = new int[matrixLength - 1][]; 
                for (int row = 0; row < matrixLength - 1; row++)
                {
                    matrix[row] = matrix[row + 1];
                    result[row] = new int[matrixLength - 1];
                    for (int col = minorColumn; col < matrixLength - 1; col++)
                    {
                        matrix[row][col] = matrix[row][col + 1];
                        result[row][col] = matrix[row][col];
                    }
                    for (int col = 0; col < minorColumn; col++)
                    {
                        result[row][col] = matrix[row][col];
                    }
                }
                return result;
            }

        }


















    }
}
