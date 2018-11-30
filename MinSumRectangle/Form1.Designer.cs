namespace MinSumRectangle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGV_Matrix = new System.Windows.Forms.DataGridView();
            this.dataGV_Result = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.numUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.numUpDownCol = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCol)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_Matrix
            // 
            this.dataGV_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Matrix.Location = new System.Drawing.Point(12, 33);
            this.dataGV_Matrix.Name = "dataGV_Matrix";
            this.dataGV_Matrix.Size = new System.Drawing.Size(274, 309);
            this.dataGV_Matrix.TabIndex = 0;
            // 
            // dataGV_Result
            // 
            this.dataGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Result.Location = new System.Drawing.Point(292, 33);
            this.dataGV_Result.Name = "dataGV_Result";
            this.dataGV_Result.Size = new System.Drawing.Size(231, 309);
            this.dataGV_Result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходная матрица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Прямоугольный фрагмент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "К-во строк";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "К-во столбцов";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(553, 319);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "Условие";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(553, 222);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(169, 20);
            this.textBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Минимальная сумма";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(554, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(554, 95);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(168, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Сгенерировать матрицу";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(647, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // numUpDownRow
            // 
            this.numUpDownRow.Location = new System.Drawing.Point(553, 43);
            this.numUpDownRow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownRow.Name = "numUpDownRow";
            this.numUpDownRow.Size = new System.Drawing.Size(76, 20);
            this.numUpDownRow.TabIndex = 15;
            this.numUpDownRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownCol
            // 
            this.numUpDownCol.Location = new System.Drawing.Point(653, 43);
            this.numUpDownCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownCol.Name = "numUpDownCol";
            this.numUpDownCol.Size = new System.Drawing.Size(69, 20);
            this.numUpDownCol.TabIndex = 16;
            this.numUpDownCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 358);
            this.Controls.Add(this.numUpDownCol);
            this.Controls.Add(this.numUpDownRow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV_Result);
            this.Controls.Add(this.dataGV_Matrix);
            this.Name = "Form1";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_Matrix;
        private System.Windows.Forms.DataGridView dataGV_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numUpDownRow;
        private System.Windows.Forms.NumericUpDown numUpDownCol;
    }
}

