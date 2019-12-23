using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;




namespace Task5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"C:\Users\ып\Desktop\Task5\Current";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size | NotifyFilters.CreationTime;
            watcher.Filter = "*.txt";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.Deleted += new FileSystemEventHandler(OnDeleted);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
            Console.WriteLine("Press q to exit");
            while (Console.Read() != 'q') ;
        }
        
        
        static void OnChanged(object source, FileSystemEventArgs e)
        {
            Log.Changes(@"C:\Users\ып\Desktop\Task5\Current");
        }
        static void OnRenamed(object source, RenamedEventArgs e)
        {
            Log.Changes(@"C:\Users\ып\Desktop\Task5\Current");


            Console.WriteLine("File: {0} renamed to {1} !", e.OldFullPath, e.FullPath);
        }
        static void OnDeleted(object source, FileSystemEventArgs e)
        {

            Log.Changes(@"C:\Users\ып\Desktop\Task5\Current");
        }
        static void OnCreated(object source, FileSystemEventArgs e)
        {
            Log.Changes(@"C:\Users\ып\Desktop\Task5\Current");
        }

    }
}
