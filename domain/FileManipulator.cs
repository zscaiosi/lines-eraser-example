using System;
using System.IO;

namespace br.com.zscaiosi.domain
{
    class FileManipulator
    {
        private string uri { get; }
        public FileManipulator(string uri) {
            this.uri = uri;
        }
        public List<string> ReadFileLines() {
            return File.ReadAllLines(this.uri).ToList();
        }
        public void WriteFileLines(List<string> lines) {
            File.WriteAllLines(this.uri, lines);
        }
    }
}