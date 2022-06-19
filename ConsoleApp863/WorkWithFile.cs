using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp863
{
    /// <summary>
    /// класс, который считает объем файлов 
    /// </summary>
    static public class WorkWithFile
    {
        /// <summary>
        /// считаем объем файлов в указанной директории (и в глубине)
        /// </summary>
        /// <param name="info"> заданная директория </param>
        /// <returns> общий объем файлов </returns>
        static public long FileSize(DirectoryInfo info, ref int j) 
        {
            long total = 0;
           
            try
            {
                foreach (FileInfo file in info.GetFiles())
                {
              //      Console.WriteLine("Файл {0} имеет объем {1}", file, file.Length); если вдруг нужно знать объем файла
                    total += file.Length;
                    j++;              
                }
                foreach (DirectoryInfo directory in info.GetDirectories())
                {
                    total += FileSize(directory,ref j);             
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Процесс не удался: {0}", e.Message);
            }
            return total;
        }
    }
}
