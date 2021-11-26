using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8tsk
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выберите любую папку на своем компьютере, имеющую вложенные директории. 
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов.
             * 
             */
            Console.WriteLine("Введите адрес папки");
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {            
               Console.WriteLine("Список каталогов");
                foreach (var cats in dir.GetDirectories())
                {                
                    Console.WriteLine(cats.Name);                
                    Console.WriteLine("Список подкаталогов");                
                    foreach (var subcats in cats.GetDirectories())
                    {                    
                        Console.WriteLine(subcats.Name);                    
                        foreach (var fl1 in cats.GetFiles())
                        {                        
                            Console.WriteLine("список файлов в подкаталогах");                        
                            Console.WriteLine(fl1.Name);
                        }
                    }
                }            
                Console.WriteLine("список файлов");            
               foreach (var fl in dir.GetFiles())
                {                
                    Console.WriteLine(fl.Name);
                } 
            }
            Console.ReadKey();
        } 
    }
}
