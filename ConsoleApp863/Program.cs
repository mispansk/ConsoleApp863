using System;
using System.IO;

namespace ConsoleApp863
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dirName = new DirectoryInfo(@"C:\Work\skillFactori\123"); // Прописываем путь к директории 
            long tottal = 0; // объем файлов до удаления
            long tottal1 = 0; //объем фалов после удаления ненужных
            int i = 0; // количество файлов

            if (dirName.Exists)
            {
                tottal = WorkWithFile.FileSize(dirName, ref i); // считаем объем файлов до удаления
                Console.WriteLine("Oбъем папки до удаления ненужных файлов и папок: {0}\nколичество файлов всего: {1} ", tottal, i);
                bool res = WorkWithDirectory.DeleteDirByTime(dirName); // удаляем ненужные файлы
                i = 0;
                tottal1 = WorkWithFile.FileSize(dirName, ref i); // считаем объем оставшихся файлов
                Console.WriteLine("Объем удаленных файлов {0}", tottal - tottal1);
                Console.WriteLine("Oбъем папки после удаления ненужных файлов и папок: {0}\nколичество оставшихся файлов: {1}", tottal1, i);
            }
            else
            {
                Console.WriteLine("Некорректно указан путь");
            }
            
            Console.ReadKey();
        }
    }
}
