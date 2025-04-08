using System;

/* 
 * In order to escape, write a function that sorts an array of integers in ascending order. 
 * You cannot use any built-in methods or libraries. 
 * You can use any sorting algorithm you want, but you must implement it yourself.
 */

class Program {
    static void Main() {
        int[] numbers = {1034, 70, 230, 302, 5};
        SortArray(numbers);
        Console.WriteLine("Sorted Numbers: " + String.Join(", ", numbers));
    }

    static void SortArray(int[] arr) {
      // Implement sorting logic here
      // You cannot use any built-in methods or libraries
      // You can use any sorting algorithm you want
      // You must implement it yourself
      // For example, you can use Bubble Sort, Selection Sort, Insertion Sort, Merge Sort, Quick Sort, etc.
        
      // for (int i = 0; i < arr.Length; i++) 
      // {
      //   if (i + 1 < arr.Length && arr[i] > arr[i + 1]) 
      //   {
      //     int temp = arr[i];
      //     arr[i] = arr[i + 1];
      //     arr[i + 1] = temp;
      //     SortArray(arr);
      //   }
      // } 
    }
}
