﻿using System.CodeDom.Compiler;
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

class Solution
{

    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a)
    {
        var cont = 0;
        var canceledClass = "";
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] <= 0)
            {
                cont++;
            }
            
        }
        if (cont < k)
        {
            canceledClass = "YES";
        }
        else
        {
            canceledClass = "NO";
        }
        return canceledClass;

    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
