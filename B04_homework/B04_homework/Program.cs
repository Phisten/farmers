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
            //break語法的用途是跳離當前所在的{大括號},可以與其他語法結合使用  如for迴圈,while迴圈的{大括弧}內部
            switch (HomeworkIndex)
            {
                case 1:
                    sort_3number();
                    break;
                case 2:
                    IsPrime();
                    break;
                case 3:
                    miningGame();
                    break;
                default:
                    Console.WriteLine("Homework %d not found",HomeworkIndex);
                    break;

            }
            Console.ReadLine();
        }
        //-------------------------------------------------------------------------------------------------------------------

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
            num1 = 123131213;

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
        //-------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// hw2 讓使用者輸入一個整數,輸出該數字是否為質數
        /// 質數的定義請自行查詢
        /// </summary>
        static void IsPrime()
        {

        }
        //-------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// hw3 請閱讀已有的程式碼,並依照敘述將遊戲完成:
        /// 與AI交替在一條礦坑上挖掘競爭積分
        /// 礦坑內散布著各種物品,挖到物品時會改變積分或有獨特功能:
        ///     空坑    什麼都沒挖到,積分不變
        ///     金礦    10分
        ///     鐵礦    1分
        ///     BTC     30分
        ///     炸彈    分數歸0
        ///     藏寶圖  得知下列隨機一個物品的位置
        ///     鑽頭    下個回合可挖掘兩個坑
        ///     寶箱    隨機獲得10~20分
        ///     防爆裝  挖到炸彈時不會扣分
        ///     探測器  得知距離探測器最近的物品的距離
        ///     
        /// 勝利條件:
        ///     到達分數上限時立刻獲勝
        ///     輪替完回合數上限時,積分較高者獲勝
        ///     所有挖掘點已被開採時,積分較高者獲勝
        /// 
        /// 
        /// 本題著重在練習閱讀他人程式碼,練習基於原有架構下修改或新增功能
        /// 因此程式複雜度較高,請積極發問
        /// </summary>
        static void miningGame()
        {
            // ----------------------- init -----------------------
            //game rule config
            int scoreLimit = 35; //分數上限,先到達者獲勝
            int roundLimit = 15; //回合上限,玩家與AI交替挖掘的上限次數

            //map config
            int pitMapLength = 50; //礦坑內的挖掘點總數
            int[] pitMap = new int[pitMapLength]; //礦坑藏寶紀錄

            //item list
            int itemCount = 10;
            int[] itemScore = new int[itemCount];
            string[] itemName = new string[itemCount];
            initItem(ref itemName, itemCount);

            // ------------------- game process ---------------------
            bool gaming = true;
            while (gaming)
            {



            }


        }
        /// <summary>  設定物品名稱  </summary>
        static void initItem(ref string[] itemName,int itemCount)
        {
            //TODO: (非必要) 請搜尋 "C# 宣告陣列" 嘗試化簡本函式內itemName的初值設定程式碼
            itemName = new string[itemCount];
            int indexTemp = 0;
            itemName[indexTemp++] = "空坑";
            itemName[indexTemp++] = "金礦";
            itemName[indexTemp++] = "鐵礦";
            itemName[indexTemp++] = "BTC";
            itemName[indexTemp++] = "炸彈";
            itemName[indexTemp++] = "藏寶圖";
            itemName[indexTemp++] = "鑽頭";
            itemName[indexTemp++] = "寶箱";
            itemName[indexTemp++] = "防爆裝";
            itemName[indexTemp++] = "探測器";
        }
        //-------------------------------------------------------------------------------------------------------------------
    }
}
