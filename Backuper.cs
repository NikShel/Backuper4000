using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backuper4000
{
    class Backuper
    {
        public static void CopyDirectory(string sourcePath, string destinationPath)
        {
            if (!sourcePath.EndsWith(@"\"))
                sourcePath += @"\";
            Stack<string> directoryPaths = new Stack<string>();
            directoryPaths.Push("");

            while (directoryPaths.Count != 0)
            {
                string currentRelativePath = directoryPaths.Pop();
                string currentSourcePath = Path.Combine(sourcePath, currentRelativePath);
                string currentDestinationPath = Path.Combine(destinationPath, currentRelativePath);
                //Directory.CreateDirectory(currentDestinationPath);

                foreach (string directoryPath in Directory.EnumerateDirectories(currentSourcePath))
                {
                    directoryPaths.Push(directoryPath.Remove(0, sourcePath.Length));
                }

                foreach (string filePath in Directory.EnumerateFiles(currentSourcePath))
                {
                    File.Copy(filePath, Path.Combine(currentDestinationPath, Path.GetFileName(filePath)));
                }
            }
        }
    }
}
