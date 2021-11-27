using System;
using System.IO;

namespace _8tsk3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вручную подготовьте текстовый файл с фрагментом текста. 
             * Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
             */
            Console.WriteLine("Введите полный адрес файла");
            string path = Console.ReadLine();
            //Считываем количество строк
            int lin = File.ReadAllLines(path).Length;
            //Считываем количество слов
            string swor = File.ReadAllText(path);
            char[] ch = { ' ','\n'};            
            string[] arsw = swor.Split(ch);
            int wor = arsw.Length;
            //Считываем количество символов
            int sym = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string ssym = sr.ReadToEnd();
                    char[] asym = ssym.ToCharArray();
                    foreach (char a in asym)
                    {
                        if (a != '\r' && a != '\n' && a != ' ')
                            sym++;
                    }
                }
            }
            Console.WriteLine("Количество символов в файле - {0} ", sym);
            Console.WriteLine("Количество слов в файле  - {0} ", wor);
            Console.WriteLine("Количество строк в файле -  {0} ", lin);
            Console.ReadKey();
        }
    }
}
