// See https://aka.ms/new-console-template for more information
using br.com.zscaiosi.applicaton.services;

namespace br.com.zscaiosi
{
    public class Program
    {
        private const string URI = ".\\test.txt";
        static void Main(string[] args) {
            FileModificationService service = new EraseLinesService(URI);

            int erased = service.EraseLinesBy("60");
            Console.WriteLine("Erasing all lines prefixed with 60");
            erased += service.EraseLinesBy("70");
            Console.WriteLine("Erasing all lines prefixed with 60");
            Console.WriteLine("Erased " + erased + " lines from " + URI);
        }
    }
}

