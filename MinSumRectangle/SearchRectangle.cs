using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSumRectangle
{
    class SearchRectangle
    {
        private int RowStart = 0;  // номер строки с которой начинается прямоугольный фрагмент
        private int RowEnd = 0;   // номер строки которой заканчивается прямоугольный фрагмент
        private int ColStart = 0;  // номер столбца с которого начинается прямоугольный фрагмент
        private int ColEnd = 0;    // номер столбца с которым заканчивается прямоугольный фрагмент

        private int minSum = 101;

        private int[][] matrix; // исходная матрица
        int n_str, // количество строк
            n_col; // количество столбцов

        public int N_str { get { return n_str; } set { n_str = value; } }
        public int N_col { get { return n_col; } set { n_col = value; } }
        public int MinSum { get { return minSum; } }

        public SearchRectangle(int[][] _matrix)
        {
            matrix = _matrix;
        }

        // поиск минимального вектора (подмассива)
        public static int FindMinSubArray(int[] arr, out int minSumStartIndex, out int minSumLastIndex)
        {
            minSumStartIndex = 0;
            minSumLastIndex = 0;
            int minSum = arr[0];

            int lastSumStartIndex = 0;
            int lastSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                //суммируем элементы массива
                lastSum += arr[i]; 
                //если сумма получилась больше, чем текущий элемент, то в сумму запомним текущий элемент
                if (lastSum > arr[i])
                {
                    lastSum = arr[i];
                    lastSumStartIndex = i;
                }

                //если текущая сумма меньше минимума, переопределяем минимум и его границы
                if (minSum > lastSum)
                {
                    minSumStartIndex = lastSumStartIndex;
                    minSumLastIndex = i;
                    minSum = lastSum;
                }
            }
            return minSum;
        }

        // очистка массива
        public static void СlearArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
        }

        // поиск минимального прямоугольного фрагмента (подматрицы)
        public void MinSubMatrix()
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;
            int start = 0;
            int fin = 0;
            int[] partialSum = new int[colCount];  // текущий подмассив для вычисления минимальной суммы

            // Идем по всем строкам
            for (int rowStart = 0; rowStart < rowCount; rowStart++)
            {
                // очищаем подмассив сумм
                СlearArray(partialSum);

                //  для текущего прямоугольника, ограниченного rowstart и rowend считаем сумму элементов по столбцам
                for (int rowEnd = rowStart; rowEnd < rowCount; rowEnd++)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        partialSum[i] += matrix[rowEnd][i]; 
                    }

                    // ищем координаты столбцов, и считаем сумму
                    int tempMinSum = FindMinSubArray(partialSum, out start, out fin);

                    // если полученная сумма, меньше глобального минимума 
                    // запоминаем сумму и координаты
                    if (tempMinSum < minSum)
                    {
                        RowStart = rowStart;
                        RowEnd = rowEnd;
                        ColStart = start;
                        ColEnd = fin;
                        minSum = tempMinSum;
                    }
                }
            }
        }

        /// Функция образующая минимальную матрицу по заданным координатам
        public int[][] getNewMatrix()
        {
            n_str = RowEnd - RowStart + 1;
            n_col = ColEnd - ColStart + 1;
            int[][] newMatrix = new int[n_str][];
            for (int i = 0; i < n_str; i++)
                newMatrix[i] = new int[n_col];
            for (int i = RowStart, k = 0; i <= RowEnd; i++, k++)
            {
                for (int j = ColStart, l = 0; j <= ColEnd; j++, l++)
                    newMatrix[k][l] = matrix[i][j];
            }
            return newMatrix;
        }
    }
}
