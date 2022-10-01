using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensions = new SortedDictionary<string, List<FileInfo>>();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extensions[fileInfo.Extension].Add(fileInfo);
            }
            var orderedExtensionsFiles = extensions.OrderByDescending(x => x.Value.Count);
            StringBuilder sb = new StringBuilder();
            foreach (var extensionFile in orderedExtensionsFiles)
            {
                sb.AppendLine(extensionFile.Key);

                var orderedFiles = extensionFile.Value.OrderByDescending(f => f.Length);

                foreach (var file in orderedFiles)
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }

            return sb.ToString();
            throw new NotImplementedException();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(filePath, textContent);
            throw new NotImplementedException();
        }
    }
}
