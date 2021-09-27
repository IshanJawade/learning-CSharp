using System;

class SearchTheElement {
    static bool EleIsPresent (int n, int[] arr){
        for (int i=0; i < arr.Length; i++){
            if (n == arr[i])
                return true;
            else
                return false;
        }
    }
    public static bool Main(){
        int[] arr = {15, 30, 45, 60, 75, 90, 105};

        Console.WriteLine("Which number you want to find?");
        int findNum = Convert.ToInt32(Console.ReadLine());

        EleIsPresent(findNum, arr);
    }
}