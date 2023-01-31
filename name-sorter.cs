/*
 * The main class of a program that sorts a list of names read from a text file and output to the console and a new file.
 * To run the program, use "name-sorter unsorted-names-list.txt"
 */

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {

        // Check if the correct number of arguments was provided
        if (args.Length != 1)
        {
            Console.WriteLine("Please use \"name-sorter [file-path]\" to run this program");
            return;
        }

        // Check if the file exists
        if (!File.Exists(args[0]))
        {
            Console.WriteLine("Error: file does not exist");
            return;
        }

        //Read in the names from a file and convert to a list of strings
        List<string> names = File.ReadAllLines(args[0]).ToList();

        // Check if the file is empty
        if (!names.Any())
        {
            Console.WriteLine("Error: file is empty");
            return;
        }
        
        Sorter sorter = new Sorter();
        List<string> sortedNames = sorter.Sort(names);

        // Write the sorted names to the console
        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }

        //Write the sorted names to a file named sorted-names-list.txt
        File.WriteAllLines("./sorted-names-list.txt", sortedNames);
    }
}
