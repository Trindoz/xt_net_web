using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Task5
{
    class DataFile
    {
        public FileInfo[] GetAtributes(string path)
        {    
                DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ып\Desktop\Task5\Archives");
                FileInfo[] txtfiles = dir.GetFiles("*.txt");
                return txtfiles;      
        }
        public FileStream  GetContentFile(string path) 
        {
          return File.OpenRead(path);
        }

    }
    public class Log
    {
        public static void Writing(string date)
        {
        Dictionary<string,List<DataFile>> files = new Dictionary<string, List<DataFile>>();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ып\Desktop\Task5\Archives");
            FileInfo[] txtfiles = dir.GetFiles("*.txt");  
            files.Add(date, txtfiles);               
            string serialized = JsonConvert.SerializeObject(files);
            File.AppendAllText(@"C:\Users\ып\Desktop\Task5\.txt", serialized);
        }        
        public static void Changes(string current)
        {
            string sourceDir = current;
            string backupDir = @"C:\Users\ып\Desktop\Task5\Archives";

            try
            {
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");
                foreach (string f in txtList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
    }
    }




