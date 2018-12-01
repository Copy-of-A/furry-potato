using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinSumRectangle
{
    public partial class Form1 : Form
    {
        int countRow; // кол-во строк
        int countCol; // кол-во столбцов
        int[][] matr; 

        public Form1()
        {
            InitializeComponent();
            btnGenerate.Enabled = true;
            btnSearch.Enabled = false;
        }

        //Выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Условие задания
        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("13b. Поиск прямоугольного фрагмента с минимальной суммой в двухмерной матрице.", "Условие задачи");
        }

        //Очистка (сброс)
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            dataGV_Result.Rows.Clear();
            dataGV_Matrix.Rows.Clear();
            dataGV_Matrix.RowCount = 1;
            dataGV_Matrix.ColumnCount = 1;
            btnSearch.Enabled = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            countRow= (int)(numUpDownRow.Value); //считываем к-во строк
            countCol = (int)(numUpDownCol.Value); //считываем к-во столбцов

            dataGV_Matrix.RowCount = countRow;
            dataGV_Matrix.ColumnCount = countCol;

            //создаём матрицу
            matr = new int[countRow][];
            for (int i = 0; i < countRow; i++)
                matr[i] = new int[countCol];

            //рандомно заполняем её элементами и добавляем их в гридвью
            Random rnd = new Random();
            dataGV_Result.Rows.Clear();
            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countCol; j++)
                {
                    int n = rnd.Next(-100,100);
                    matr[i][j] = n;
                    dataGV_Matrix.Rows[i].Cells[j].Value = n;
                }
            }
            dataGV_Matrix.AutoResizeColumns();
            btnSearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchRectangle search = new SearchRectangle(matr);
            search.MinSubMatrix();
            matr = search.getNewMatrix(); // получаем прямоугольник с минимальной суммой
            countCol = search.N_col;
            countRow = search.N_str;

            //в результирующую гридвью отображаем получившуюся матрицу
            dataGV_Result.RowCount = countRow;
            dataGV_Result.ColumnCount = countCol;
            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countCol; j++)
                {
                    dataGV_Result.Rows[i].Cells[j].Value = matr[i][j];
                }
            }
            dataGV_Result.AutoResizeColumns();
            // вывод минимальной суммы
            textBox.Text = search.MinSum.ToString(); 
        }
    }
}
