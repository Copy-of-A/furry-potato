﻿using System;
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
        int[,] matr = new int[10, 10];

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

            Random rnd = new Random();
            dataGV_Result.Rows.Clear();
            for (int i = 0; i < countRow; i++)
            {
                for (int j = 0; j < countCol; j++)
                {
                    int n = rnd.Next(-100,100);
                    matr[i, j] = n;
                    dataGV_Matrix.Rows[i].Cells[j].Value = n;
                }
            }
            dataGV_Matrix.AutoResizeColumns();
            btnSearch.Enabled = true;
        }
    }
}
