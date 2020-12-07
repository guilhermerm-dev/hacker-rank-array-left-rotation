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

namespace hacker_rank_array_left_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRotations = 1;
            int[] arr = { 1, 2, 3, 4, 5 };
            printElements(rotateLeft(numberOfRotations, arr.ToList()));
        }

        private static void printElements(List<int> arr)
        {
            arr.ForEach(item => Console.WriteLine($"{item}"));
        }

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            // var array = arr.ToArray();
            // for (int n = 0; n < d; n++)
            // {
            //     int firstElement = array.Take(1).FirstOrDefault();
            //     for (int i = 0; i < array.Length - 1; i++)
            //         array[i] = array[i + 1];

            //     array[array.Length - 1] = firstElement;
            // }
            // return array.ToList();

            // arr.Skip(d).ToList().ForEach(item => Console.WriteLine($"{item}"));
            // Console.WriteLine();
            // arr.Take(d).ToList().ForEach(item => Console.WriteLine($"{item}"));

            return arr.Skip(d).Concat(arr.Take(d)).ToList();
        }
    }
}
