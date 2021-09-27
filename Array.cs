using System;

class Array {
    public static void Main(){

        // Declaration method 1 
        int[] arr = {300, 400, 600, 800, 1000}; 

        for (int i=0; i < arr.Length; i++){
            Console.WriteLine(arr[i]);
        } 

        // Declaration Method 2
        int[] arr2 = new int[5];

        int count = 350;
        for (int i=0; i < arr2.Length; i++){
            arr2[i] = count;
            count += 234;
        }

        for (int i=0; i < arr2.Length; i++){
            Console.WriteLine(arr2[i]);
        }
    }
}