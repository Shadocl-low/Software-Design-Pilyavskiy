using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileLoggerAdapter : Logger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(string fileName)
        {
            string projectRoot = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", "..", ".."));
            string fullPath = Path.Combine(projectRoot, fileName);
            fileWriter = new FileWriter(fullPath);
        }

        public new void Log(string message)
        {
            fileWriter.WriteLine($"[LOG] {message}");
        }

        public new void Error(string message)
        {
            fileWriter.WriteLine($"[ERROR] {message}");
        }

        public new void Warn(string message)
        {
            fileWriter.WriteLine($"[WARNING] {message}");
        }
    }
}
