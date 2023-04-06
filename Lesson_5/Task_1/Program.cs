/*
* Lesson 5 Task 1: a file manager
* Author: Stanislav Mykhailenko, parts of code used from DanyilMykytenko's repository
* License: Unlicense
*/


﻿using Lesson5_WorkWithFiles.FileSystem;
using Lesson5_WorkWithFiles.WorkWithFiles;
using Lesson5_WorkWithFiles.CopyDirectory;

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
            dir = WorkWithFileSystem.Cd(WorkWithFileSystem.AskStringInput("Enter the directory name: "), dir);
            break;
        case "dir":
            WorkWithFileSystem.GetDirectoryFiles(dir);
            break;
        case "open":
            ReadWrite.ReadByPath(WorkWithFileSystem.AskStringInput("Enter the file name: "));
            break;
        case "mv":
            string moveSource = Path.Combine(dir, WorkWithFileSystem.AskStringInput("Enter the source: "));
            string moveDestination = Path.Combine(dir, WorkWithFileSystem.AskStringInput("Enter the destination: "));

            if (Directory.Exists(moveSource) || File.Exists(moveSource))
                Directory.Move(moveSource, moveDestination);
            else
                Console.WriteLine("Not found.");
            break;
        case "rm":
            string path = Path.Combine(dir, WorkWithFileSystem.AskStringInput("Enter the file or directory to delete: "));

            if (Directory.Exists(path))
                Directory.Delete(path, true);
            else if (File.Exists(path))
                File.Delete(path);
            else
                Console.WriteLine("Not found.");
            break;
        case "cp":
            string copySource = Path.Combine(dir, WorkWithFileSystem.AskStringInput("Enter the source: "));
            string copyDestination = Path.Combine(dir, WorkWithFileSystem.AskStringInput("Enter the destination: "));

            if (Directory.Exists(copySource))
                CopyDirectory.Copy(copySource, copyDestination, true);
            else if (File.Exists(copySource))
                File.Copy(copySource, copyDestination);
            else
                Console.WriteLine("Not found.");
            break;
        case "info":
            FileInfoOperation.GetFileInfo(WorkWithFileSystem.AskStringInput("Enter the file name: "));
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
}
