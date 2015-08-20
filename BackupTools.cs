using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backuper4000
{
    enum MessageType
    {
        Success,
        Information,
        Error,
        CriticalError
    }

    class BackupTools
    {
        public static void StartBackup(string sourcePath, string destinationPath, Action<string> log)
        {
            bool isSuccessfull = true;
            try
            {
               CopyDirectory(sourcePath, destinationPath, log);
            }
            catch (Exception error)
            {
                isSuccessfull = false;
                log("ERROR");
                log(error.Message);
                log("\n\nSTACKTRACE");
                log(error.StackTrace);
            }

            if (isSuccessfull)
                log("BACKUP FINISHED SUCCESSFULLY");
        }

        public static void CopyDirectory(string sourcePath, string destinationPath, Action<string> log)
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
                Directory.CreateDirectory(currentDestinationPath);

                foreach (string directoryPath in Directory.EnumerateDirectories(currentSourcePath))
                {
                    directoryPaths.Push(directoryPath.Remove(0, sourcePath.Length));
                }

                foreach (string filePath in Directory.EnumerateFiles(currentSourcePath))
                {
                    log(String.Format("<{0}>", Path.GetFileName(filePath)));
                    File.Copy(filePath, Path.Combine(currentDestinationPath, Path.GetFileName(filePath)));
                }
            }
        }
    }
}
