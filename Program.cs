// See https://aka.ms/new-console-template for more information
namespace Modul5_103022400129
{
    class Program
    {
        static void Main(string[] args)
        {
            PemrosesData pd = new PemrosesData();
            long s = pd.DapatkanNilaiTerbesar<long>(10, 04, 09);
            Console.WriteLine("Nilai terbesar " + s);
        }
    }
}