using System.Collections.Generic;
using System;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i=1; i<=255; i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i =0; i<=127; i++){
                Console.WriteLine(2*i+1);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i<=255; i++){
                sum +=1;
                Console.WriteLine($"New number:{i}: Sum:{sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            foreach (int item in numbers){
                Console.WriteLine(item);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i< numbers.Length; i++){
                if (numbers[i] > max){
                    max = numbers[i];
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++){
                sum += numbers[i];
            }
            Console.WriteLine($"Sum is {sum}. Length is {numbers.Length}");
            Console.WriteLine($"Average is {sum / numbers.Length}");

        }
        public static int[] OddArray()
        {
            List<int> arr = new List<int>();
            for (int i = 1; i <= 255; i+=2){
                arr.Add(i);
            }
            return arr;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach (int value in numbers){
                if (value > y){
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++){
                numbers[i]= numbers[i] * numbers[i];
            }
            foreach (int value in numbers){
                Console.WriteLine(value);
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++){
                if (numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
            foreach (int value in numbers){
                Console.WriteLine(value);
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            foreach (int value in numbers){
                if (value < min){
                    min = value;
                }
                if (value > max){
                    max = value;
                }
                sum += value;
            }

            Console.WriteLine($"Min is {min}");
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Average = {sum/numbers.Length}");           
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++){
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
            foreach(int value in numbers){
                Console.WriteLine(value);
            }
        } 
        public static object[] NumToString(int[] numbers)
        {
            object[] newarr =new object[numbers.Length];
            for (int i = 0; i< numbers.Length; i++){
                if(numbers[i]<0){
                    newarr[i] = "Dojo";
                }
                else{
                    newarr[i] = numbers[i];
                }
            }
            foreach (var value in newarr){
                Console.WriteLine(value);
            }
            return newarr;
        }
        }
    }
}
