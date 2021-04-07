using System;
using System.Collections.Generic;
using System.IO;

namespace PreData
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayAction = { };
            string[] ArrayData = { };
            List<string> Lista = new List<string>(ArrayAction);
            List<string> Listd = new List<string>(ArrayData);
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader("action.txt")) //读文件还有action.txt
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Lista.Add(line);
                    }

                    ArrayAction = Lista.ToArray();
                
                }
                using (StreamReader sr = new StreamReader("DATA.txt")) //读文件还有action.txt
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Listd.Add(line);
                    }

                    ArrayData = Listd.ToArray();

                }
                for(int i = 0;i < ArrayData.Length;i++)
                {
                    Console.WriteLine("\\hline");
                    Console.Write("(");
                    Console.Write(i + 1);
                    Console.Write(") & ");
                    Console.Write(ArrayData[i]);
                    Console.Write(" & ");
                    Console.Write(ArrayAction[i]);
                    Console.WriteLine(" \\\\");
                    /*
                     *     \hline 
    (2) & 用户输入指令./str1指示\\shell运行可执行文件str1 & 程序shell执行命令 & √ \\ 
                    */
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
