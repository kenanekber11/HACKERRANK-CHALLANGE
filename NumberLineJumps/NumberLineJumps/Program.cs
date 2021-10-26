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

class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */
    
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        string metin1 = "YES";
        string metin2 = "NO";
        for (int i = 1; i <= 10000; i++)
        {
          
            double ilkKanguru = x1 + (v1 * i);
            double ikinciKanguru = x2 + (v2 * i);
            double sonuc = ilkKanguru / ikinciKanguru;
            double sonuc1 = Math.Ceiling(sonuc);
            if (sonuc== 1)
            {
                Console.WriteLine(i + ". adımda üst üste düşüyor..");
                break;
            }
            else if (i == 10000)
            {
                return metin2;
            }

          
        }
        return metin1;
       
    }

}

class Solution
{
    public static void Main(string[] args)
    {

       
      

        int x1 = Convert.ToInt32(Console.ReadLine());

        int v1 = Convert.ToInt32(Console.ReadLine());

        int x2 = Convert.ToInt32(Console.ReadLine());

        int v2 = Convert.ToInt32(Console.ReadLine());

        string result = Result.kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
        Console.ReadKey();
        
    }
}
