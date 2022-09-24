using System.Text.RegularExpressions;

namespace br.com.zscaiosi.applicaton.services {
    interface FileModificationService
    {
        public int EraseLinesBy(Regex pattern);
        public int EraseLinesBy(string prefix);
    }
}