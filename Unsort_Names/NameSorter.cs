using System;
using System.Collections.Generic;
using System.IO;

namespace UnsortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "/Users/adampatrick/Projects/Unsort_Names/Unsort_Names/unsorted-names-list.txt";  //relative paths
            string outputFilePath = "/Users/adampatrick/Projects/Unsort_Names/Unsort_Names/sorted-names-list.txt";

            try
            {
                List<string> names = FileReader.ReadNamesFromFile(inputFilePath);
                List<string> sortedNames = NameSorter.SortByLastName(names);

                foreach (string name in sortedNames)
                {
                    Console.WriteLine(name);
                }

                FileWriter.WriteNamesToFile(outputFilePath, sortedNames);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class FileReader
    {
        public static List<string> ReadNamesFromFile(string filePath)
        {
            List<string> names = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }

            return names;
        }
    }

   public class NameSorter
    {
        public static List<string> SortByLastName(List<string> names)
        {
            List<string> sortedNames = new List<string>(names);

            sortedNames.Sort((a, b) =>
            {
                string[] nameA = a.Split(' ');
                string[] nameB = b.Split(' ');
                return string.Compare(nameA[nameA.Length - 1], nameB[nameB.Length - 1]);
            });

            return sortedNames;
        }
    }

    public class FileWriter
    {
        public static void WriteNamesToFile(string filePath, List<string> names)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string name in names)
                {
                    sw.WriteLine(name);
                }
            }
        }
    }
}