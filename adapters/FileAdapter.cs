namespace br.com.zscaiosi.adapters {
    interface FileAdapter
    {
        public List<string> ReadFileLines();
        public void WriteFileLines(List<string> lines);
    }
}