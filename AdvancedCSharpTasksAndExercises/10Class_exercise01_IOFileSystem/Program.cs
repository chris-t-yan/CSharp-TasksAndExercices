﻿using System;
using System.IO;

namespace _10Class_exercise01_IOFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //string absolutePath = "C:\\Users\\ivan\\text.txt";
            //string relativePath = "../text.txt";

            //working with Directories
            string currentDirectory = Directory.GetCurrentDirectory();

            string directoryPath = ($@"{currentDirectory}\NewFolder");

            //PrintIfDirectoryExists(directoryPath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory {directoryPath} created.");
            }
            PrintIfDirectoryExists(directoryPath);

            //if (Directory.Exists(directoryPath))
            //{
            //    Directory.Delete(directoryPath);
            //    Console.WriteLine($"Directory {directoryPath} deleted.");
            //}
            //PrintIfDirectoryExists(directoryPath);


            //working with files
            string filePath = Path.Combine(directoryPath, "NewText.txt");

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Hola Mundo!!!!");
            }

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);

                Console.WriteLine(content);
            }

        }
        public static void PrintIfDirectoryExists(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Directory {path} exists.");
            }
            else
            {
                Console.WriteLine($"Directory {path} does not exists.");
            }
        }
    }
}
