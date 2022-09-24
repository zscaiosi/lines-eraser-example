using System;
using System.Text.RegularExpressions;
using br.com.zscaiosi.adapters;

namespace br.com.zscaiosi.applicaton.services
{
    class EraseLinesService : FileModificationService
    {
        private string uri { get; }
        private FileAdapter fileAdapter;
        private List<string> originalLines;
        private List<string> currentLines;
        public EraseLinesService(string uri) {
            this.uri = uri;
            this.fileAdapter = new FileManipulator(uri);
            this.originalLines = fileAdapter.ReadFileLines();
            this.currentLines = this.originalLines;
        }

        public int EraseLinesBy(Regex pattern) {
            throw new NotImplementedException("TO_DO");
        }

        public int EraseLinesBy(string prefix) {
            UpdateWithLinesDifferentFrom(prefix);

            fileAdapter.WriteFileLines(this.currentLines);

            return CountErasedLines();
        }

        private void UpdateWithLinesDifferentFrom(string prefix) {
            List<string> filtered = this.currentLines.FindAll(element => !element.StartsWith(prefix));
            this.currentLines = filtered;
        }

        private int CountErasedLines() {
            return this.originalLines.Count - this.currentLines.Count;
        }
    }
}