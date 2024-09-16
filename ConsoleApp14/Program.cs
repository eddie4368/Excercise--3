using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };// line declares a 2D integer array named matrix and initializes with single row containing values 1 to 8

            
            Console.WriteLine("Matrix elements:");// prints a header indicating that the matrix elements will be displayed.
            for (int i = 0; i < matrix.GetLength(0); i++)//loop iterates over each row in the matrix elements will be displayed.
            {
                for (int j = 0; j < matrix.GetLength(1); j++)// inner loop iterates over each column in the current row.
                {
                    Console.Write($"{matrix[i, j]} ");//prints the current element 
                }
                Console.WriteLine();//moves to the next line after printing all elements in the current row
            }

            
            int sum = 0;// declares an interger variable sum and initializes it to 0

            for (int i = 0; i < matrix.GetLength(0); i++)// outer loop iterates over each row in the matrix again.
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//inner loop iterates over column in the current row again
                {
                    sum += matrix[i, j];// line adds the current element to the sum variable. 
                }
            }
            Console.WriteLine($"Sum: {sum}");//prints the calculated sum.

         
            int[,] transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];// declares a new 2D integer array named trasposedMatrix with dimensions that are the opposite of the original matrix
            for (int i = 0; i < matrix.GetLength(0); i++)//loop iterates over each row in the original matrix
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//inner loop iterates over each column in the current row
                {
                    transposedMatrix[j, i] = matrix[i, j];//assigns the elment at row "i" and column "j" in the original matrix to the element at row j and column i in the transposedmatrix. 
                }
            }
            Console.WriteLine("Transposed matrix:");//prints a header indicating that the transported matrix will be displayed.
            for (int i = 0; i < transposedMatrix.GetLength(0); i++)//outer loop iterates over each row in the transpoedMatrix
            {
                for (int j = 0; j < transposedMatrix.GetLength(1); j++)//inner loop iterates over each column in current row.
                {
                    Console.Write($"{transposedMatrix[i, j]} ");//prints the current element followed by a space.
                }
                Console.WriteLine();//moves to the next line after printing all elements in the current row.
            }
        }
    }
}