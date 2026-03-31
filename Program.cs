// See https://aka.ms/new-console-template for more information
namespace Modul5_103022400129
{
        class Program
    {
        static void Main(string[] args)
        {
            SimpleDatabase<int> obj = new SimpleDatabase<int>();
            obj.AddNewData(12);
            obj.AddNewData(34);
            obj.AddNewData(56);

            obj.PrintAllData();
        }
    }
}