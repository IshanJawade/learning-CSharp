using System;

class SearchTheElement {
    public static void Main(){
        int[] arr = {15, 30, 45, 60, 75, 90, 105};
        int index = 0;
        bool flag=false;
        Console.WriteLine("Which number you want to find?");
        int findNum = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i < arr.Length; i++){
            if (findNum == arr[i]){ 
                flag = true;
                break;
            }   
            else{
                index ++;
            }    
        }
        if (flag)
            Console.WriteLine("Element is present at index {0}.", index);
        else
            Console.WriteLine("Element is not present.");
    }
}