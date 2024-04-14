using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410010_辜懷居031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入文字，以空格分隔，最少1字最大50字：");

            // 輸入的文字
            string userInput = Console.ReadLine();
            // 檢定
            if (userInput.Length < 1 || userInput.Length > 50)
            {
                Console.WriteLine("輸入的文字必須介於1到50字。");
                return;
            }
            // 用 String.Split() 把文字分割成陣列
            string[] words = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("請輸入文字，限定1字：");
            string userInput2 = Console.ReadLine();
            if (userInput2.Length < 1 || userInput2.Length > 1)
            {
                Console.WriteLine("只能輸入1個字。");
                return;
            }
            string CheckWord = userInput2.ToLower();

            // 用來紀錄包含CheckWord的索引值的陣列
            List<int> indexes = new List<int>();

            // 使用 for 迴圈遍歷陣列
            for (int i = 0; i < words.Length; i++)
            {
                // 用Contains檢查是否包含CheckWord
                if (words[i].Contains(CheckWord))
                {
                    indexes.Add(i);
                }
            }

            // 將結果輸出
            if (indexes.Count > 0)
            {
                string result = "[" + String.Join(", ", indexes) + "]";
                Console.WriteLine(result);
            }
            else
            {
                string result = "[" + String.Join(", ", indexes) + "]";
                Console.WriteLine(result);
            }
        }
    }
}
