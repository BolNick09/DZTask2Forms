namespace DZTask2Forms
{
    partial class FrmTasks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            gbSort = new GroupBox();
            btnGenArray = new Button();
            btnSort = new Button();
            lblSortedArray = new Label();
            lblUnsortedArray = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tbMax = new TextBox();
            tbMin = new TextBox();
            tbCount = new TextBox();
            label8 = new Label();
            label6 = new Label();
            gbParseText = new GroupBox();
            btnParseString = new Button();
            lblSumA = new Label();
            tbStringToParse = new TextBox();
            label7 = new Label();
            gbArraySum = new GroupBox();
            btnArraySum = new Button();
            lblArraySum = new Label();
            tbArray = new TextBox();
            label5 = new Label();
            gbFactorial = new GroupBox();
            btnCalcFactorial = new Button();
            lblFactResult = new Label();
            tbFact = new TextBox();
            label4 = new Label();
            gbTask2 = new GroupBox();
            btnCalcSum = new Button();
            lblResult = new Label();
            tbPrecision = new TextBox();
            label3 = new Label();
            tbX = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pnlMain.SuspendLayout();
            gbSort.SuspendLayout();
            gbParseText.SuspendLayout();
            gbArraySum.SuspendLayout();
            gbFactorial.SuspendLayout();
            gbTask2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(gbSort);
            pnlMain.Controls.Add(gbParseText);
            pnlMain.Controls.Add(gbArraySum);
            pnlMain.Controls.Add(gbFactorial);
            pnlMain.Controls.Add(gbTask2);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(586, 607);
            pnlMain.TabIndex = 0;
            // 
            // gbSort
            // 
            gbSort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbSort.Controls.Add(btnGenArray);
            gbSort.Controls.Add(btnSort);
            gbSort.Controls.Add(lblSortedArray);
            gbSort.Controls.Add(lblUnsortedArray);
            gbSort.Controls.Add(label11);
            gbSort.Controls.Add(label10);
            gbSort.Controls.Add(label9);
            gbSort.Controls.Add(tbMax);
            gbSort.Controls.Add(tbMin);
            gbSort.Controls.Add(tbCount);
            gbSort.Controls.Add(label8);
            gbSort.Controls.Add(label6);
            gbSort.Location = new Point(18, 402);
            gbSort.Name = "gbSort";
            gbSort.Size = new Size(558, 193);
            gbSort.TabIndex = 5;
            gbSort.TabStop = false;
            gbSort.Text = "Сортировка массива";
            // 
            // btnGenArray
            // 
            btnGenArray.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenArray.Location = new Point(354, 57);
            btnGenArray.Name = "btnGenArray";
            btnGenArray.Size = new Size(196, 29);
            btnGenArray.TabIndex = 14;
            btnGenArray.Text = "Сгенерировать массив";
            btnGenArray.UseVisualStyleBackColor = true;
            btnGenArray.Click += btnGenArray_Click;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSort.Location = new Point(354, 89);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(196, 29);
            btnSort.TabIndex = 13;
            btnSort.Text = "Отсортировать массив";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblSortedArray
            // 
            lblSortedArray.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSortedArray.AutoSize = true;
            lblSortedArray.Location = new Point(211, 170);
            lblSortedArray.Name = "lblSortedArray";
            lblSortedArray.Size = new Size(137, 20);
            lblSortedArray.TabIndex = 12;
            lblSortedArray.Text = "Исходный массив:";
            // 
            // lblUnsortedArray
            // 
            lblUnsortedArray.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUnsortedArray.AutoSize = true;
            lblUnsortedArray.Location = new Point(211, 141);
            lblUnsortedArray.Name = "lblUnsortedArray";
            lblUnsortedArray.Size = new Size(137, 20);
            lblUnsortedArray.TabIndex = 11;
            lblUnsortedArray.Text = "Исходный массив:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(6, 170);
            label11.Name = "label11";
            label11.Size = new Size(195, 20);
            label11.TabIndex = 10;
            label11.Text = "Отсортированный массив:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(6, 141);
            label10.Name = "label10";
            label10.Size = new Size(137, 20);
            label10.TabIndex = 9;
            label10.Text = "Исходный массив:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 92);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 8;
            label9.Text = "Максимальная граница:";
            // 
            // tbMax
            // 
            tbMax.Location = new Point(218, 89);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(63, 27);
            tbMax.TabIndex = 7;
            // 
            // tbMin
            // 
            tbMin.Location = new Point(218, 56);
            tbMin.Name = "tbMin";
            tbMin.Size = new Size(63, 27);
            tbMin.TabIndex = 6;
            // 
            // tbCount
            // 
            tbCount.Location = new Point(218, 20);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(63, 27);
            tbCount.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 59);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
            label8.TabIndex = 4;
            label8.Text = "Минимальная граница:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(211, 20);
            label6.TabIndex = 3;
            label6.Text = "Количество чисел в массиве:\r\n";
            // 
            // gbParseText
            // 
            gbParseText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbParseText.Controls.Add(btnParseString);
            gbParseText.Controls.Add(lblSumA);
            gbParseText.Controls.Add(tbStringToParse);
            gbParseText.Controls.Add(label7);
            gbParseText.Location = new Point(18, 294);
            gbParseText.Name = "gbParseText";
            gbParseText.Size = new Size(558, 102);
            gbParseText.TabIndex = 4;
            gbParseText.TabStop = false;
            gbParseText.Text = "Количество букв А в строке";
            // 
            // btnParseString
            // 
            btnParseString.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnParseString.Location = new Point(336, 28);
            btnParseString.Name = "btnParseString";
            btnParseString.Size = new Size(214, 29);
            btnParseString.TabIndex = 7;
            btnParseString.Text = "Вычислить количество букв";
            btnParseString.UseVisualStyleBackColor = true;
            btnParseString.Click += btnParseString_Click;
            // 
            // lblSumA
            // 
            lblSumA.AutoSize = true;
            lblSumA.Location = new Point(6, 72);
            lblSumA.Name = "lblSumA";
            lblSumA.Size = new Size(73, 20);
            lblSumA.TabIndex = 4;
            lblSumA.Text = "Сумма = ";
            // 
            // tbStringToParse
            // 
            tbStringToParse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbStringToParse.Location = new Point(80, 30);
            tbStringToParse.Name = "tbStringToParse";
            tbStringToParse.Size = new Size(250, 27);
            tbStringToParse.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 33);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 2;
            label7.Text = "Строка:";
            // 
            // gbArraySum
            // 
            gbArraySum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbArraySum.Controls.Add(btnArraySum);
            gbArraySum.Controls.Add(lblArraySum);
            gbArraySum.Controls.Add(tbArray);
            gbArraySum.Controls.Add(label5);
            gbArraySum.Location = new Point(12, 186);
            gbArraySum.Name = "gbArraySum";
            gbArraySum.Size = new Size(564, 102);
            gbArraySum.TabIndex = 3;
            gbArraySum.TabStop = false;
            gbArraySum.Text = "Сумма элементов массива";
            // 
            // btnArraySum
            // 
            btnArraySum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnArraySum.Location = new Point(391, 28);
            btnArraySum.Name = "btnArraySum";
            btnArraySum.Size = new Size(159, 29);
            btnArraySum.TabIndex = 7;
            btnArraySum.Text = "Вычислить сумму";
            btnArraySum.UseVisualStyleBackColor = true;
            btnArraySum.Click += button1_Click_1;
            // 
            // lblArraySum
            // 
            lblArraySum.AutoSize = true;
            lblArraySum.Location = new Point(6, 72);
            lblArraySum.Name = "lblArraySum";
            lblArraySum.Size = new Size(73, 20);
            lblArraySum.TabIndex = 4;
            lblArraySum.Text = "Сумма = ";
            // 
            // tbArray
            // 
            tbArray.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbArray.Location = new Point(80, 30);
            tbArray.Name = "tbArray";
            tbArray.Size = new Size(305, 27);
            tbArray.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 2;
            label5.Text = "Массив: ";
            // 
            // gbFactorial
            // 
            gbFactorial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFactorial.Controls.Add(btnCalcFactorial);
            gbFactorial.Controls.Add(lblFactResult);
            gbFactorial.Controls.Add(tbFact);
            gbFactorial.Controls.Add(label4);
            gbFactorial.Location = new Point(372, 12);
            gbFactorial.Name = "gbFactorial";
            gbFactorial.Size = new Size(204, 168);
            gbFactorial.TabIndex = 1;
            gbFactorial.TabStop = false;
            gbFactorial.Text = "Вычисление факториала";
            // 
            // btnCalcFactorial
            // 
            btnCalcFactorial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalcFactorial.Location = new Point(6, 128);
            btnCalcFactorial.Name = "btnCalcFactorial";
            btnCalcFactorial.Size = new Size(184, 29);
            btnCalcFactorial.TabIndex = 7;
            btnCalcFactorial.Text = "Вычислить факториал";
            btnCalcFactorial.UseVisualStyleBackColor = true;
            btnCalcFactorial.Click += button1_Click;
            // 
            // lblFactResult
            // 
            lblFactResult.AutoSize = true;
            lblFactResult.Location = new Point(16, 73);
            lblFactResult.Name = "lblFactResult";
            lblFactResult.Size = new Size(34, 20);
            lblFactResult.TabIndex = 6;
            lblFactResult.Text = "x = ";
            // 
            // tbFact
            // 
            tbFact.Location = new Point(56, 31);
            tbFact.Name = "tbFact";
            tbFact.Size = new Size(43, 27);
            tbFact.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 34);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "x = ";
            // 
            // gbTask2
            // 
            gbTask2.Controls.Add(btnCalcSum);
            gbTask2.Controls.Add(lblResult);
            gbTask2.Controls.Add(tbPrecision);
            gbTask2.Controls.Add(label3);
            gbTask2.Controls.Add(tbX);
            gbTask2.Controls.Add(label2);
            gbTask2.Controls.Add(label1);
            gbTask2.Location = new Point(12, 12);
            gbTask2.Name = "gbTask2";
            gbTask2.Size = new Size(354, 168);
            gbTask2.TabIndex = 0;
            gbTask2.TabStop = false;
            gbTask2.Text = "Сумма ряда";
            // 
            // btnCalcSum
            // 
            btnCalcSum.Location = new Point(6, 128);
            btnCalcSum.Name = "btnCalcSum";
            btnCalcSum.Size = new Size(189, 29);
            btnCalcSum.TabIndex = 6;
            btnCalcSum.Text = "Вычислить сумму ряда";
            btnCalcSum.UseVisualStyleBackColor = true;
            btnCalcSum.Click += btnCalcSum_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(6, 94);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(34, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "x = ";
            // 
            // tbPrecision
            // 
            tbPrecision.Location = new Point(293, 46);
            tbPrecision.Name = "tbPrecision";
            tbPrecision.Size = new Size(43, 27);
            tbPrecision.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 49);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 3;
            label3.Text = "Допустимая погрешность:";
            // 
            // tbX
            // 
            tbX.Location = new Point(46, 46);
            tbX.Name = "tbX";
            tbX.Size = new Size(43, 27);
            tbX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "x = ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(272, 20);
            label1.TabIndex = 0;
            label1.Text = "Числовой ряд формата х, 1/х, 3/х,...n/x\r\n";
            // 
            // FrmTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 607);
            Controls.Add(pnlMain);
            MinimumSize = new Size(604, 654);
            Name = "FrmTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Набор заданий";
            pnlMain.ResumeLayout(false);
            gbSort.ResumeLayout(false);
            gbSort.PerformLayout();
            gbParseText.ResumeLayout(false);
            gbParseText.PerformLayout();
            gbArraySum.ResumeLayout(false);
            gbArraySum.PerformLayout();
            gbFactorial.ResumeLayout(false);
            gbFactorial.PerformLayout();
            gbTask2.ResumeLayout(false);
            gbTask2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private GroupBox gbFactorial;
        private GroupBox gbTask2;
        private Label label2;
        private Label label1;
        private Button btnCalcSum;
        private Label lblResult;
        private TextBox tbPrecision;
        private Label label3;
        private TextBox tbX;
        private Label lblFactResult;
        private TextBox tbFact;
        private Label label4;
        private Button btnCalcFactorial;
        private GroupBox gbArraySum;
        private Label lblArraySum;
        private TextBox tbArray;
        private Label label5;
        private Button btnArraySum;
        private GroupBox gbParseText;
        private Button btnParseString;
        private Label lblSumA;
        private TextBox tbStringToParse;
        private Label label7;
        private GroupBox gbSort;
        private Label label9;
        private TextBox tbMax;
        private TextBox tbMin;
        private TextBox tbCount;
        private Label label8;
        private Label label6;
        private Button btnGenArray;
        private Button btnSort;
        private Label lblSortedArray;
        private Label lblUnsortedArray;
        private Label label11;
        private Label label10;
    }
}
