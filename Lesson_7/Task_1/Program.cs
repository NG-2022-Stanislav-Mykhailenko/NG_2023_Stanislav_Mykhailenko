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
            await WorkWithFileSystem.GetDirectoryFilesAsync(dir);
            break;
        case "open":
            await ReadFile.ReadByPathAsync(UserInput.AskStringInput("Enter the file name: "));
            break;
        case "mv":
            string moveSource = Path.Combine(dir, UserInput.AskStringInput("Enter the source: "));
            string moveDestination = Path.Combine(dir, UserInput.AskStringInput("Enter the destination: "));
            await Operations.CopyAsync(moveSource, moveDestination, false);
            break;
        case "rm":
            string path = Path.Combine(dir, UserInput.AskStringInput("Enter the file or directory to delete: "));
            await Operations.DeleteAsync(path);
            break;
        case "cp":
            string copySource = Path.Combine(dir, UserInput.AskStringInput("Enter the source: "));
            string copyDestination = Path.Combine(dir, UserInput.AskStringInput("Enter the destination: "));
            await Operations.CopyAsync(copySource, copyDestination);
            break;
        case "info":
            Operations.GetFileInfo(UserInput.AskStringInput("Enter the file name: "));
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
}
