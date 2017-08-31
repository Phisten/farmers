using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B04_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int HomeworkIndex = 1; //修改索引數字選擇進行測試的題目

            //switch語法會依據右方括弧內變數來執行對應的case-break程式碼區段
            //  當沒有case與switch右邊括號內變數相符時,會執行default內的程式碼
            //break語法的用途是跳離當前大括號,可以與其他語法結合使用  如for迴圈,while迴圈的大括弧內部
            switch (HomeworkIndex)
            {
                case 1:
                    sort_3number();
                    break;
                case 2:
                    IsPrime();
                    break;
                case 3:
                    mining();
                    break;
                default:
                    Console.WriteLine("Homework %d not found",HomeworkIndex);
                    break;

            }
            Console.ReadLine();
        }

        /// <summary>
        /// hw1 :
        ///     讓使用者輸入三個數字,個別存進三個變數num1,num2,num3內
        ///     然後將三個變數由小到大排序後輸出(num1 ＜＝ num2 ＜＝ num3)  
        /// ex:
        /// input
        ///     9
        ///     6
        ///     5
        /// output
        ///     5 
        ///     6 
        ///     9
        ///     
        /// hw1-sub1
        ///     請設計一函數,讓使用者輸入一個數字,並將其轉換成int後回傳(return)
        /// 
        /// hw1-sub2
        ///     請設計一函數,能將傳入兩個整數內的數值對換,請注意傳入的兩個變數須以傳參考方式(在變數型態前加上ref )
        /// 
        /// </summary>
        static void sort_3number()
        {
            int num1 = 0, num2 = 0, num3 = 0;


            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
        // hw1-sub1 請設計一函數,讓使用者輸入一個數字,並將其轉換成int後回傳(return)
        static int inputInt()
        {
            int userInput = 0;

            return userInput;
        }
        // hw1-sub2 請設計一函數,能將傳入兩個整數內的數值對換,請注意傳入的兩個變數須以傳參考方式(在變數型態前加上ref )
        static void swap()
        {
            int temp;
        }

        /// <summary>
        /// hw2 讓使用者輸入一個整數,輸出該數字是否為質數
        /// </summary>
        static void IsPrime()
        {

        }

        /// <summary>
        /// hw3 
        /// </summary>
        static void mining()
        {

        }
    }
}
