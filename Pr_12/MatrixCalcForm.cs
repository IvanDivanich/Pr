using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMatrixCalc
{
    public partial class MatrixCalcForm : Form
    {
        private int MatrixARank;
        private double MatrixDeterminant;
        private int[,] MatrixA, MatrixB, MatrixResult;
        private double[,] doubleMatrixResult;
        public MatrixCalcForm()
        {
            InitializeComponent();
        }

        //Overall methods
        private void ViewResultMatrix(int matrixNum)
        {
            dataGridView_MatrixResult[0, 0].Value = matrixNum;
        }
        private void ViewResultMatrix(double matrixNum)
        {
            dataGridView_MatrixResult[0, 0].Value = matrixNum;
        }
        private void ViewResultMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    dataGridView_MatrixResult[row, col].Value = matrix[row, col];
                }
            }
        }
        private void ViewResultMatrix(double[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    dataGridView_MatrixResult[row, col].Value = matrix[row, col];
                }
            }
        }
        private void DatagridFillIn(DataGridView data, NumericUpDown Rows, NumericUpDown Columns)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            data.AllowUserToAddRows = false;

            for (int i = 0; data.Columns.Count < Columns.Value; i++)
            {
                data.Columns.Add($"Col{i}", "");
            }
            for (int i = 0; data.Rows.Count < Rows.Value; i++)
            {
                data.Rows.Add();
            }

            data.ColumnHeadersVisible = false;
            data.RowHeadersVisible = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void DatagridFillIn(DataGridView data, int[,] Matrix)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            data.AllowUserToAddRows = false;

            for (int i = 0; data.Columns.Count < Matrix.GetLength(1); i++)
            {
                data.Columns.Add($"Col{i}", "");
            }
            for (int i = 0; data.Rows.Count < Matrix.GetLength(0); i++)
            {
                data.Rows.Add();
            }

            data.ColumnHeadersVisible = false;
            data.RowHeadersVisible = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void DatagridFillIn(DataGridView data)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            data.AllowUserToAddRows = false;

            data.Columns.Add($"Col{1}", "");
            data.Rows.Add();

            data.ColumnHeadersVisible = false;
            data.RowHeadersVisible = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void DatagridFillIn(DataGridView data, double[,] Matrix)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            data.AllowUserToAddRows = false;

            for (int i = 0; data.Columns.Count < Matrix.GetLength(1); i++)
            {
                data.Columns.Add($"Col{i}", "");
            }
            for (int i = 0; data.Rows.Count < Matrix.GetLength(0); i++)
            {
                data.Rows.Add();
            }

            data.ColumnHeadersVisible = false;
            data.RowHeadersVisible = false;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private int[,] FillMatrix(DataGridView data)
        {
            int[,] array;
            int rows = data.Rows.Count;
            int cols = data.Columns.Count;
            array = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    array[r, c] = Convert.ToInt32(data[c, r].Value);
                }
            }
            return array;
        }

        //A and B matrix methods
        private int[,] Multiply(int[,] matrixA, int[,] matrixB)
        {
            matrixA = FillMatrix(dataGridView_MatrixA);
            matrixB = FillMatrix(dataGridView_MatrixB);

            int rows1 = matrixA.GetLength(0);
            int cols1 = matrixA.GetLength(1);

            int cols2 = matrixB.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    result[j, i] = sum;
                }
            }
            return result;
        }
        private int[,] Summ(int[,] matrixA, int[,] matrixB)
        {
            matrixA = FillMatrix(dataGridView_MatrixA);
            matrixB = FillMatrix(dataGridView_MatrixB);

            int rows1 = matrixA.GetLength(0);
            int cols1 = matrixA.GetLength(1);

            int cols2 = matrixB.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[j, i] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
        }
        private int[,] Subtraction(int[,] matrixA, int[,] matrixB)
        {
            matrixA = FillMatrix(dataGridView_MatrixA);
            matrixB = FillMatrix(dataGridView_MatrixB);

            int rows1 = matrixA.GetLength(0);
            int cols1 = matrixA.GetLength(1);

            int cols2 = matrixB.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[j, i] = matrixA[i, j] - matrixB[i, j];
                }
            }
            return result;
        }

        //A matrix methods
        private double[,] InverseMatrix(int[,] matrix)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            double[,] result;

            if (rows != columns)
            {
                result = null;
            }

            // создание расширенной матрицы
            double[,] extendedMatrix = new double[rows, 2 * columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    extendedMatrix[i, j] = matrix[i, j];
                }
                extendedMatrix[i, i + columns] = 1;
            }

            // преобразование расширенной матрицы к единичной
            for (int k = 0; k < rows; k++)
            {
                double pivot = extendedMatrix[k, k];
                if (pivot == 0)
                {
                    result = null;
                }

                for (int j = 0; j < 2 * columns; j++)
                {
                    extendedMatrix[k, j] /= pivot;
                }

                for (int i = 0; i < rows; i++)
                {
                    if (i == k)
                    {
                        continue;
                    }

                    double factor = extendedMatrix[i, k];
                    for (int j = 0; j < 2 * columns; j++)
                    {
                        extendedMatrix[i, j] -= factor * extendedMatrix[k, j];
                    }
                }
            }

            // получение обратной матрицы
            result = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = extendedMatrix[i, j + columns];
                }
            }

            return result;
        }
        private int[,] TransposeMatrix(int[,] matrix)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] transposeMatrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposeMatrix[j, i] = matrix[i, j];
                }
            }

            return transposeMatrix;
        }
        private int RankMatrix(int[,] matrix)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int rank = 0;

            for (int i = 0; i < rows; i++)
            {
                bool foundPivot = false;
                for (int j = rank; j < columns; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        foundPivot = true;
                        SwapColumns(matrix, rank, j);
                        break;
                    }
                }

                if (foundPivot)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        if (j != i && matrix[j, rank] != 0)
                        {
                            AddRows(matrix, i, j, -matrix[j, rank] / matrix[i, rank]);
                        }
                    }
                    rank++;
                }
            }

            return rank;
        }
        private void SwapColumns(int[,] matrix, int column1, int column2)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, column1];
                matrix[i, column1] = matrix[i, column2];
                matrix[i, column2] = temp;
            }
        }
        private void AddRows(int[,] matrix, int srcRow, int dstRow, int factor)
        {
            int columns = matrix.GetLength(1);
            for (int i = 0; i < columns; i++)
            {
                matrix[dstRow, i] += factor * matrix[srcRow, i];
            }
        }
        private double GetDeterminant(int[,] matrix)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double det = 1;

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < cols - i; j++)
                {
                    det *= matrix[j, i];
                }
                det *= (-1) ^ i;
            }

            return det;
        }
        private int[,] FindMinors(int[,] matrix)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] minors = new int[rows + 1, cols + 1];

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    int minor = 1;
                    for (int k = 0; k < cols; k++)
                    {
                        minor *= matrix[i - 1, k];
                    }
                    minors[i, j] = minor;
                }
            }

            return minors;
        }
        public double[,] MultiplyWithScalar(int[,] matrix, double scalar)
        {
            matrix = FillMatrix(dataGridView_MatrixA);
            MatrixB = FillMatrix(dataGridView_MatrixB);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[,] result = new double[rows, cols];

            for (int j = 0; j < cols; j++)
                for (int k = 0; k < rows; k++)
                {
                    double sum = 0;
                    for (int i = 0; i < rows; i++)
                        sum += matrix[k, i] * scalar;

                    result[k, j] = sum;
                }
            return result;
        }


        //Buttons

        //Copy matrix
        private void button_CopyDown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_MatrixA.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_MatrixB.Columns.Count; j++)
                {
                    for (int k = 0; k < dataGridView_MatrixA.Columns.Count; k++)
                    {
                        dataGridView_MatrixB[j, i].Value = dataGridView_MatrixA[j, i].Value;
                    }
                }
            }
        }
        private void button_CopyUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_MatrixA.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_MatrixB.Columns.Count; j++)
                {
                    for (int k = 0; k < dataGridView_MatrixA.Columns.Count; k++)
                    {
                        dataGridView_MatrixA[j, i].Value = dataGridView_MatrixB[j, i].Value;
                    }
                }
            }
        }
        private void button_CopyLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_MatrixResult.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_MatrixB.Columns.Count; j++)
                {
                    for (int k = 0; k < dataGridView_MatrixResult.Columns.Count; k++)
                    {
                        dataGridView_MatrixB[j, i].Value = dataGridView_MatrixResult[j, i].Value;
                    }
                }
            }
        }

            //Matrix fill in
        private void button_MatrixAFillIn_Click(object sender, EventArgs e)
        {
            DatagridFillIn(dataGridView_MatrixA, numericUpDown_RowsMatrixA, numericUpDown_ColumnsMatrixA);
        }
        private void button_MatrixBFillIn_Click(object sender, EventArgs e)
        {
            DatagridFillIn(dataGridView_MatrixB, numericUpDown_RowsMatrixB, numericUpDown_ColumnsMatrixB);
        }

            //A and B matrix operations
        private void button_Multiply_Click(object sender, EventArgs e)
        {
            MatrixResult = Multiply(MatrixA, MatrixB);
            DatagridFillIn(dataGridView_MatrixResult, MatrixResult);
            ViewResultMatrix(MatrixResult);
        }
        private void button_Summ_Click(object sender, EventArgs e)
        {
            MatrixResult = Summ(MatrixA, MatrixB);
            DatagridFillIn(dataGridView_MatrixResult, MatrixResult);
            ViewResultMatrix(MatrixResult);
        }
        private void button_Subtraction_Click(object sender, EventArgs e)
        {
            MatrixResult = Subtraction(MatrixA, MatrixB);
            DatagridFillIn(dataGridView_MatrixResult, MatrixResult);
            ViewResultMatrix(MatrixResult);
        }

            //A matrix operations
        private void button_InverseMatrix_Click(object sender, EventArgs e)
        {
            doubleMatrixResult = InverseMatrix(MatrixA);
            DatagridFillIn(dataGridView_MatrixResult, doubleMatrixResult);
            ViewResultMatrix(doubleMatrixResult);
        }
        private void button_Transpose_Click(object sender, EventArgs e)
        {
            MatrixResult = TransposeMatrix(MatrixA);
            DatagridFillIn(dataGridView_MatrixResult, MatrixResult);
            ViewResultMatrix(MatrixResult);
        }
        private void button_MatrixRank_Click(object sender, EventArgs e)
        {
            MatrixARank = RankMatrix(MatrixA);
            DatagridFillIn(dataGridView_MatrixResult);
            ViewResultMatrix(MatrixARank);
        }
        private void button_MatrixDeterminant_Click(object sender, EventArgs e)
        {
            MatrixDeterminant = GetDeterminant(MatrixA);
            DatagridFillIn(dataGridView_MatrixResult);
            ViewResultMatrix(MatrixDeterminant);
        }
        private void button_MatrixMinors_Click(object sender, EventArgs e)
        {
            MatrixResult = FindMinors(MatrixA);
            DatagridFillIn(dataGridView_MatrixResult, MatrixResult);
            ViewResultMatrix(MatrixResult);
        }
        private void button_MultiplyWithScalar_Click(object sender, EventArgs e)
        {
            doubleMatrixResult = MultiplyWithScalar(MatrixA, double.Parse(dataGridView_MatrixB[0, 0].Value.ToString()));
            DatagridFillIn(dataGridView_MatrixResult, doubleMatrixResult);
            ViewResultMatrix(doubleMatrixResult);
        }
    }
}