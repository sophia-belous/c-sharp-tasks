using System;
using System.Runtime.Serialization;

namespace MatrixLib
{
    public class Matrix : IComparable
    {
        private double[,] _matrix;

        public int CountOfRow { get; private set; }
        public int CountOfCol { get; private set; }

        public Matrix(int row, int col)
        {
            if (row <= 0 && col <= 0)
                throw new MatrixException(Resource.NegativeException);

            CountOfRow = row; CountOfCol = col;

            _matrix = new double[CountOfRow, CountOfCol];            
        }

        public Matrix(int countOfSquareMatrix)
        {
            if (countOfSquareMatrix <= 0)
                throw new MatrixException(Resource.NegativeException);

            _matrix = new double[countOfSquareMatrix, countOfSquareMatrix];
            CountOfRow = CountOfCol = countOfSquareMatrix;
        }

        public Matrix(double[,] array)
        {
            if (array == null)
                throw new MatrixException(Resource.NullException);

            CountOfRow = array.GetLength(0);
            CountOfCol = array.GetLength(1);

            _matrix = (double[,])(array.Clone());
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i> CountOfRow - 1 || j < 0 || j > CountOfCol - 1)
                    throw new MatrixException(Resource.InvalidIndex);

                return _matrix[i, j];
            }
            set 
            {
                if (i < 0 || i > CountOfRow - 1 || j < 0 || j > CountOfCol - 1)
                    throw new MatrixException(Resource.InvalidIndex);

                _matrix[i, j] = value; 
            }
        }

        private Matrix Transpose ()
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            Matrix transpMatrix = new Matrix(this.CountOfCol, this.CountOfRow);

            for (int i = 0; i < this.CountOfRow; i++)
                for (int j = 0; j < this.CountOfCol; j++)
                    transpMatrix[j, i] = this[i, j];

            return transpMatrix;
        }

        private double FindDeterminant()
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            if (this.CountOfRow != this.CountOfCol)
                throw new MatrixException(Resource.DoesntSquareMtrxExcpt);

            Matrix newMatrix = new Matrix(this.CountOfRow, this.CountOfCol);

            for (int i = 0; i < this.CountOfRow; i++)
                for (int j = 0; j < this.CountOfCol; j++)
                    newMatrix[i, j] = this[i, j];

            const double E = 1E-9;
            double det = 1;
            int k = 0;

            if (this.CountOfRow == 1)
                return this[0, 0];

            if (newMatrix.CountOfCol == 2 && newMatrix.CountOfRow == 2)
                return newMatrix[0, 0] * newMatrix[1, 1] - newMatrix[1, 0] * newMatrix[0, 1];

            for (int i = 0; i < newMatrix.CountOfCol; i++)
            {
                k = i;
                for (int j = i + 1; j < newMatrix.CountOfCol; j++)
                    if (Math.Abs(newMatrix[j, i]) > Math.Abs(newMatrix[k, i]))
                        k = j;

                if (Math.Abs(newMatrix[k, i]) < E)
                {
                    det = 0;
                    break;
                }

                SwapRows(ref newMatrix, i, k);

                if (i != k) 
                    det *= -1;

                det *= newMatrix[i, i];

                for (int j = i + 1; j < newMatrix.CountOfCol; j++)
                    newMatrix[i, j] /= newMatrix[i, i];

                for (int j = 0; j < newMatrix.CountOfCol; j++)
                    if ((j != i) && (Math.Abs(newMatrix[j, i]) > E))
                        for (k = i + 1; k < newMatrix.CountOfCol; k++)
                            newMatrix[j, k] -= newMatrix[i, k] * newMatrix[j, i];
            }
            return det;
        }

        private static void SwapRows(ref Matrix matrix, int firstRow, int secondRow)
        {
            if (matrix == null)
                throw new MatrixException(Resource.NullException);

            if (firstRow < 0 || secondRow < 0)
                throw new MatrixException(Resource.NegativeException);

            double tempMtrx = 0;

            for (int i = 0; i < matrix.CountOfCol; i++)
            {
                tempMtrx = matrix[firstRow, i];
                matrix[firstRow, i] = matrix[secondRow, i];
                matrix[secondRow, i] = tempMtrx;
            }
        }   

        private double GetMinor(int firstIndex, int secondIndex)
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            if (firstIndex < 0 || secondIndex < 0)
                throw new MatrixException(Resource.NegativeException);

            Matrix minorMtrx = new Matrix(this.CountOfCol - 1);

            for (int i = 0, k = 0; i < this.CountOfCol && k < minorMtrx.CountOfCol; i++, k++)
            {
                if (i == firstIndex) i++;

                for (int j = 0, l = 0; j < this.CountOfCol && l < minorMtrx.CountOfCol; j++, l++)
                {
                    if (j == secondIndex) j++;

                    minorMtrx[k, l] = this[i, j];
                }
                
            }

            return minorMtrx.FindDeterminant();            
        }

        private Matrix GetCofactor()
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            Matrix newMtrx = new Matrix(this.CountOfCol);

            for (int i = 0; i < newMtrx.CountOfCol; i++)
                for (int j = 0; j < newMtrx.CountOfCol; j++)
                    newMtrx[i, j] = this.GetMinor(i, j);

            newMtrx.BiuldСofactor();

            return newMtrx;
        }

        private Matrix BiuldСofactor()
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            for (int i = 0; i < this.CountOfRow; i++)
                for (int j = 0; j < this.CountOfCol; j++)
                    if ((i + j) % 2 == 1)
                        this[i, j] *= -1;
            
            return this;
        }

        public Matrix GetInverseMatrix()
        {
            if (this == null)
                throw new MatrixException(Resource.NullException);

            if (this.FindDeterminant() == 0)
                throw new MatrixException("Inverse of a singular matrix is not possible");//

            Matrix transpMatrix = new Matrix(this.CountOfRow, this.CountOfCol);
            Matrix invMatrix = new Matrix(this.CountOfRow, this.CountOfCol);

            transpMatrix = this.GetCofactor().Transpose();

            return transpMatrix / this.FindDeterminant();            
        }

        //
        public static Matrix operator *(Matrix matrix, double number)
        {
            if (matrix == null)
                throw new MatrixException(Resource.NullException);

            for (int i = 0; i < matrix.CountOfRow; i++)
                for (int j = 0; j < matrix.CountOfCol; j++)
                    matrix[i, j] = matrix[i, j] * number;

            return matrix;
        }

        public static Matrix operator /(Matrix matrix, double number)
        {
            if (matrix == null)
                throw new MatrixException(Resource.NullException);
            //0

            for (int i = 0; i < matrix.CountOfRow; i++)
                for (int j = 0; j < matrix.CountOfCol; j++)
                    matrix[i, j] = Math.Round(matrix[i, j] / number);

            return matrix;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new MatrixException(Resource.NullException);

            if (firstMatrix.CountOfCol != secondMatrix.CountOfRow)
                throw new MatrixException(Resource.RowsAndColumnsNotAqual);

            Matrix resultMatrix = new Matrix(firstMatrix.CountOfRow, secondMatrix.CountOfCol);

            for (int i = 0; i < firstMatrix.CountOfRow; i++)
                for (int j = 0; j < secondMatrix.CountOfCol; j++)
                    for (int k = 0; k < firstMatrix.CountOfCol; k++)
                        resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];

            return resultMatrix;
        }

        public static Matrix operator /(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new MatrixException(Resource.NullException);

            if (firstMatrix.CountOfCol != secondMatrix.CountOfRow)
                throw new MatrixException(Resource.RowsAndColumnsNotAqual);

            Matrix resultMatrix = new Matrix(firstMatrix.CountOfRow, secondMatrix.CountOfCol);

            for (int i = 0; i < firstMatrix.CountOfRow; i++)
                for (int j = 0; j < secondMatrix.CountOfCol; j++)
                    for (int k = 0; k < firstMatrix.CountOfCol; k++)
                        resultMatrix[i, j] += firstMatrix[i, k] / secondMatrix[k, j];

            return resultMatrix;
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new ArgumentNullException(Resource.NullException);

            if (firstMatrix.CountOfRow != secondMatrix.CountOfRow || firstMatrix.CountOfCol != secondMatrix.CountOfCol)
                throw new MatrixException(Resource.RowsAndColumnsNotAqual);

            Matrix resultMatrix = new Matrix(firstMatrix.CountOfRow, secondMatrix.CountOfCol);

            for (int i = 0; i < firstMatrix.CountOfCol; i++)
                for (int j = 0; j < secondMatrix.CountOfCol; j++)
                    resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];                    

            return resultMatrix;
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            //f+sec *-1;
            if (firstMatrix == null || secondMatrix == null)
                throw new MatrixException(Resource.NullException);

            if (firstMatrix.CountOfRow != secondMatrix.CountOfRow || firstMatrix.CountOfCol != secondMatrix.CountOfCol)
                throw new MatrixException(Resource.RowsAndColumnsNotAqual);

            Matrix resultMatrix = new Matrix(firstMatrix.CountOfRow, secondMatrix.CountOfCol);

            for (int i = 0; i < firstMatrix.CountOfCol; i++)
                for (int j = 0; j < secondMatrix.CountOfCol; j++)
                    resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];

            return resultMatrix;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Matrix matrix = obj as Matrix;

            if (matrix != null)
                return this.FindDeterminant().CompareTo(matrix.FindDeterminant());
            else
                throw new ArgumentException(Resource.NullException);
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.CountOfRow; i++)
            {
                for (int j = 0; j < this.CountOfCol; j++)
                    str += this[i, j] + "\t";
                str += "\n";
            }
            return str;
        }
    }
}

class MatrixException : Exception
{
    public MatrixException() { }

    public MatrixException(string message) : base(message) { }

    public MatrixException(string message, Exception inner) : base(message, inner) { }

    protected MatrixException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
