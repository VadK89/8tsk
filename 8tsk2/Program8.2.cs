using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел.
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
             */
            Console.WriteLine("Введите адрес папки и через '\' добавьте название файла с раширением .txt");
            string path = Console.ReadLine();
            const int n = 10;
            int S = 0;
            //Создаем файл            
            if (!File.Exists(path))
            {
                File.CreateText(path).Close();                
            }
            // Создаем рандомный массив из 10 чисел и записываем в файл 10 произвольных чисел построчно
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                int[] ar = new int[n];
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    ar[i] = ran.Next(-50, 50);
                    //string aer = Convert.ToString(ar[i]);
                    sw.WriteLine(ar[i]);                    
                }
            }
            // Считываем числа из файла и суммируем
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    int[] arg = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        string tmp = sr.ReadLine();
                        arg[i] = Convert.ToInt32(tmp);
                        S += arg[i];
                    }
                }
            }
            //Вывод суммы чисел
            Console.WriteLine("Сумма чисел составляет {0}",S);
            Console.ReadKey();
        }
    }
}
