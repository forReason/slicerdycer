using System;
using System.IO;

namespace slicerdycer
{
    public class FileHandler
    {
        public static string[] ReadFile (string directory)
        {
            string[] lines = null;
            try
            {
                lines = File.ReadAllLines(directory);
            }
            catch (Exception)
            {
                //Commandline.Red("Something is Wrong! please check that Humanizer is in the right directory and settings are not open in another program");
                //Console.ReadKey();
                Environment.Exit(0);
            }
            return (lines);
        }
        public static void WriteFile(string[] lines, string directory)
        {
            File.WriteAllLines(directory, lines);
        }
        public static void DeleteFile(string path)
        {
            try
            {
                // A.
                // Try to delete the file.
                File.Delete(path);
            }
            catch (IOException)
            {
                // B.
                // We could not delete the file.
            }
        }

       
    }
}
