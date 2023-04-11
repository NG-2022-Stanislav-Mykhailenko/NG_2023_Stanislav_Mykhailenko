/*
* Lesson 5 Task 1: a file manager
* Author: Stanislav Mykhailenko, parts of code used from DanyilMykytenko's repository
* License: Unlicense
*/

﻿using Lesson5.Classes;
using Lesson5.Interfaces;

var dir = Directory.GetCurrentDirectory();
string? command;

while (true)
{
    Console.WriteLine(@"cd - change directory
dir - show current directory contents
open - read data
mv - move data
rm - remove data
cp - copy data
info - get data info
");

    Console.Write("{0}> ", dir);

    command = Console.ReadLine();

    switch (command)
    {
        case "cd":
            dir = WorkWithFileSystem.Cd(UserInput.AskStringInput("Enter the directory name: "), dir);
            break;
        case "dir":
            WorkWithFileSystem.GetDirectoryFiles(dir);
            break;
        case "open":
            ReadFile.ReadByPath(UserInput.AskStringInput("Enter the file name: "));
            break;
        case "mv":
            string moveSource = Path.Combine(dir, UserInput.AskStringInput("Enter the source: "));
            string moveDestination = Path.Combine(dir, UserInput.AskStringInput("Enter the destination: "));

            try
            {
                moveDestination = Validation.Check(moveSource, moveDestination);
            }
            catch (PathConflictException)
            {
                Console.WriteLine("Conflict.");
                break;
            }

            if (Directory.Exists(moveSource) || File.Exists(moveSource))
                Directory.Move(moveSource, moveDestination);
            else
                Console.WriteLine("Not found.");
            break;
        case "rm":
            string path = Path.Combine(dir, UserInput.AskStringInput("Enter the file or directory to delete: "));

            if (Directory.Exists(path))
                Directory.Delete(path, true);
            else if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine("Not found.");
            break;
        case "cp":
            string copySource = Path.Combine(dir, UserInput.AskStringInput("Enter the source: "));
            string copyDestination = Path.Combine(dir, UserInput.AskStringInput("Enter the destination: "));

            try
            {
                copyDestination = Validation.Check(copySource, copyDestination);
            }
            catch (PathConflictException)
            {
                Console.WriteLine("Conflict.");
                break;
            }

            if (Directory.Exists(copySource))
                CopyDirectory.Copy(copySource, copyDestination, true);
            else if (File.Exists(copySource))
                File.Copy(copySource, copyDestination);
            else
                Console.WriteLine("Not found.");
            break;
        case "info":
            FileInfoOperation.GetFileInfo(UserInput.AskStringInput("Enter the file name: "));
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
}
