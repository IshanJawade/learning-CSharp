using System;

class Matrix {
    public static void Main(string[] args){
        int[,] matrix_1 = new int[3,3];
        int[,] matrix_2 = new int[3,3];
        int[,] matrix_Ans = new int[3,3];
        // Input Matrices
        Console.WriteLine("Enter elements in first matrix: ");
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                matrix_1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter elements in second matrix: ");
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                matrix_2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Display Matrices
        Console.WriteLine("Your Matrices are: ");
        Console.WriteLine();
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                Console.Write(matrix_1[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                Console.Write(matrix_2[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        // Matrix Addition
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                matrix_Ans[i,j] = matrix_1[i,j] + matrix_2[i,j];
            }
        }
        Console.WriteLine("After adding two matrices: \n");
        // Display answer
        for (int i=0; i < 3; i++){
            for (int j=0; j < 3; j++){
                Console.Write(matrix_Ans[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
