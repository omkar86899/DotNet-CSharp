using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FileSystemLinqApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:/Windows/System32");
            DirectoryInfo[] directoriesInfo = directoryInfo.GetDirectories();
            FileInfo[] filesInfo = directoryInfo.GetFiles();

            var top10DirectoriesByTheirName = directoriesInfo.OrderBy(directory => directory.Name)
                                                             .Take(10);
            var top10DirectoriesByTheirSize = directoriesInfo.OrderBy(directory => GetDirectorySize(directory))
                                                             .Take(10);
            var top10FilesByTheirSizeInDescendingOrder = filesInfo.OrderByDescending(file => file.Length)
                                                                  .Take(10);
            var top10FilesByTheirSizeInAscendingOrder = filesInfo.OrderBy(file => file.Length)
                                                                 .Take(10);

            Console.WriteLine("Displaying Top 10 Folders By Their Name");
            PrintDirectoriesInfo(top10DirectoriesByTheirName);
            Console.WriteLine("\nDisplaying Top 10 Folders By Their Size");
            PrintDirectoriesInfo(top10DirectoriesByTheirSize);

            Console.WriteLine("\nDisplaying Top 10 Files By Their Size");
            PrintFilesInfo(top10FilesByTheirSizeInDescendingOrder);
            Console.WriteLine("\nDisplaying Top 10 Files By Their Size In Ascending Order");
            PrintFilesInfo(top10FilesByTheirSizeInAscendingOrder);
        }

        private static long GetDirectorySize(DirectoryInfo directoryInfo)
        {
            long totalSizeOfFiles = 0, totalSizeOfDirectories = 0;
            try
            {
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    totalSizeOfFiles += file.Length;
                }
                foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
                {
                    totalSizeOfDirectories += GetDirectorySize(directory);
                }
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
            }

            return totalSizeOfFiles + totalSizeOfDirectories;
        }

        private static void PrintFilesInfo(IEnumerable<FileInfo> files)
        {
            foreach (FileInfo file in files)
            {
                Console.WriteLine("Name: {0}, Size: {1} bytes", file.Name, file.Length);
            }
        }

        private static void PrintDirectoriesInfo(IEnumerable<DirectoryInfo> directories)
        {
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.Name);
            }
        }
    }
}
