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

    static void staircase(int n) {
        for (int i = 0; i < n; i++){
            for (int j = 1 + i; j < n; j++){
                Console.Write(" ");
            }
            for (int k = (n - 1) - i; k < n; k++){
                Console.Write("#");                                
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}