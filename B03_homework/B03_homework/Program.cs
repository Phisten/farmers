﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //hw2 請把nums陣列內的五個變數用for迴圈設定好亂數數值
            b03_array();
            
            //hw1 請依照註解完成程式
            b03_rnd();
        }

        static void b03_array()
        {
            Random rnd = new Random();

            int[] nums = new int[5];

            //--------------------------------------------------
            nums[0] = rnd.Next(10);
            nums[1] = rnd.Next(10);
            nums[2] = rnd.Next(10);
            nums[3] = rnd.Next(10);
            nums[4] = rnd.Next(10);
            //--------------------------------------------------

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums[i]);
            }
            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums[1]);
            //Console.WriteLine(nums[2]);
            //Console.WriteLine(nums[3]);
            //Console.WriteLine(nums[4]);

            //int numAAA = rnd.Next(10);
            //int num2 = rnd.Next(10);
            //int num3 = rnd.Next(10);
            //int num4 = rnd.Next(10);
            //int num5 = rnd.Next(10);

            //Console.WriteLine(numAAA);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(num5);
        }
        static void b03_rnd()
        {
            Random rnd = new Random();
            //讓使用者輸入一個數值  範圍在0~9
            //若不在這個範圍內,警告使用者 或者 後續程式跳過



            //電腦取一個範圍0~9的亂數,存在變數內



            //判斷並輸出顯示使用者與電腦選擇的數字 誰比較大,或是相等


        }
    }
}
