using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void miniMaxSum(int[] arr) {
        long min = 0;
        long max = 0;
        
        //sort numbers
        arr = InsertionSort(arr);
        
        for (int i = 0; i < arr.Length - 1; i++){
            min += arr[i];
        }
        for (int i = 1; i < arr.Length; i++){
            max += arr[i];
        }
        
        Console.WriteLine("{0} {1}", min, max);
    }
    
    //Insertion Sort Method
    static int[] InsertionSort(int[] inputArray){
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray;         
    }
    
    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
